using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using holy_water.Resources;

namespace holy_water
{
    public partial class BarList : Form
    {
        public event OnBarChanged BarChanged;
        public delegate void OnBarChanged(int barId, string barName);

        public event OnParentFormClosed ParentFormClosed;
        public delegate void OnParentFormClosed();

        private class FormThread
        {
            public delegate void BarChangedDelegate(int barId, string barName);
            public delegate void CloseFormDelegate();

            DrinkList form;
            Thread thread;

            public FormThread(DrinkList form)
            {
                this.form = form;
                this.thread = new Thread(new ThreadStart(this.Run));
            }

            public void Run()
            {
                this.form.ShowDialog();
            }

            public void Start()
            {
                this.thread.Start();
            }

            public void Stop()
            {
                try
                {
                    form.BeginInvoke(new CloseFormDelegate(this.form.Close));
                }
                catch (Exception e) { };
                thread.Join();
            }

            public void OnBarChanged(int barId, string barName)
            {
                // ignore event on form close
                if (!form.Visible)
                    return;

                form.BeginInvoke(new BarChangedDelegate(this.form.BarChanged), barId, barName);
            }

            public void ParentFormClosed()
            {
                Stop();
            }

        }



        private BarFilter barFilter = new BarFilter();

        public BarList()
        {
            InitializeComponent();

            if (Properties.Settings.Default.ThemeDark)
            {
                BackgroundImage = Properties.Resources.dark1;
            }
            else
            {
                BackgroundImage = Properties.Resources.dribbble;
            }
        }



        private void BarList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hollyWaterDbDataSet.Bars' table. You can move, or remove it, as needed.
            barsTableAdapter.Fill(hollyWaterDbDataSet.Bars);
            Enable_buttons();
            
        }

        private void Enable_buttons()
        {
            bindingNavigatorDeleteItem.Enabled = bindingNavigatorPositionItem.Enabled;
            bindingNavigatorViewDrinksItem.Enabled = bindingNavigatorPositionItem.Enabled;
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            using (EditBar editBar = new EditBar())
            {
                editBar.Text = Resource1.LabelValueNewBar;
                if (editBar.ShowDialog() == DialogResult.OK)
                {
                    DataRow row = ((DataRowView)this.barsBindingSource.Current).Row;
                    row[Resource1.BarTableName] = editBar.BarName;
                    row[Resource1.BarTableAddress] = editBar.BarAddress;
                    row[Resource1.BarTableCoordinates] = editBar.BarCoordinates != string.Empty ? editBar.BarCoordinates : null;
                    row[Resource1.BarTableAverage] = 0.00;
                    row[Resource1.BarTableCount] = 0;

                    this.barsBindingSource.EndEdit();
                    this.barsTableAdapter.Update(this.hollyWaterDbDataSet.Bars);
                }
                else
                {

                    barsBindingSource.CancelEdit();
                }

            }


        }


       

        private void dataGridView2_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (MessageBox.Show(Resource1.MessegeDelete, Resource1.Warning, MessageBoxButtons.YesNo) == DialogResult.No)
                e.Cancel = true;
        }


        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(Resource1.MessegeDelete, Resource1.Warning, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                barsBindingSource.RemoveCurrent();
                barsTableAdapter.Update(this.hollyWaterDbDataSet.Bars);
            }
                
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            editRow();
        }

        private void dataGridView2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                editRow();
                e.Handled = true;
            }
                
        }

        private void editRow()
        {
            using (EditBar editBar = new EditBar())
            {
                editBar.Text = Resource1.LabelValueNewBar;
                DataRow row = ((DataRowView)this.barsBindingSource.Current).Row;
                editBar.BarName = row[Resource1.BarTableName].ToString();
                editBar.BarAddress = row[Resource1.BarTableAddress].ToString();
                editBar.BarCoordinates = row[Resource1.BarTableCoordinates].ToString();


                if (editBar.ShowDialog() == DialogResult.OK)
                {


                    row[Resource1.BarTableName] = editBar.BarName;
                    row[Resource1.BarTableAddress] = editBar.BarAddress;
                    row[Resource1.BarTableCoordinates] = editBar.BarCoordinates != string.Empty ? editBar.BarCoordinates : null;
                    row[Resource1.BarTableAverage] = 0.00;


                    this.barsBindingSource.EndEdit();
                    this.barsTableAdapter.Update(this.hollyWaterDbDataSet.Bars);
                }
            }

        }

        private void barsBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            Enable_buttons();

            if (this.barsBindingSource.Current == null)
                return;


            DataRow row = ((DataRowView)this.barsBindingSource.Current).Row;

            if (this.BarChanged != null)
                BarChanged((int)row[Resource1.BarTableID], row[Resource1.BarTableName].ToString());

        }

        private void bindingNavigatorViewDrinksItem_Click(object sender, EventArgs e)
        {

            DataRow row = ((DataRowView)this.barsBindingSource.Current).Row;
            DrinkList drinkList = new DrinkList((int)row[Resource1.BarTableID], row[Resource1.BarTableName].ToString());
            drinkList.DrinkChanged += DrinkList_DrinkChanged;

            FormThread formThread = new FormThread(drinkList);
            this.BarChanged += formThread.OnBarChanged;
            this.ParentFormClosed += formThread.ParentFormClosed;
            formThread.Start();
        }

        private void DrinkList_DrinkChanged(int barId)
        {

            HollyWaterDbDataSet.BarsTotalsDataTable tbl = this.barsTotalsTableAdapter1.GetTotalsById(barId);
            if (tbl.Rows.Count == 0)
                return;

            DataRow totalsRow = tbl.Rows[0];

            DataRow row = ((DataRowView)this.barsBindingSource.Current).Row;
            row[Resource1.BarTableAverage] = totalsRow[Resource1.BarTableAverage];
            row[Resource1.BarTableCount]   = totalsRow[Resource1.BarTableCount];

            if (this.BarChanged != null)
                BarChanged(int.Parse(row[Resource1.BarTableID].ToString()), row[Resource1.BarTableName].ToString());

        }

        private void toolStripBackButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void toolStripFilterButton_Click(object sender, EventArgs e)
        {
            if (barFilter.ShowDialog() == DialogResult.Cancel)
                return;

            toolStripFilterButton.BackColor = Color.Red;

            if (barFilter.Filter == BarFilter.FilterType.FilterByAverage || barFilter.Filter == BarFilter.FilterType.FilterByCount)
            {
                if (barFilter.Filter == BarFilter.FilterType.FilterByAverage)
                    this.barsTableAdapter.FillByMinAverage(this.hollyWaterDbDataSet.Bars, barFilter.FilterMinValue);
                else
                    this.barsTableAdapter.FillByMinCount(this.hollyWaterDbDataSet.Bars, (int)barFilter.FilterMinValue);
            }
            else
            {
                if (barFilter.Filter == BarFilter.FilterType.Top)
                {
                    HollyWaterDbDataSet.BarsDataTable table = barsTableAdapter.GetData();
                    //HollyWaterDbDataSet.BarsDataTable row = table.AsEnumerable().Take((int)barFilter.FilterMinValue);
                    HollyWaterDbDataSet.BarsDataTable temp = new HollyWaterDbDataSet.BarsDataTable();
                    foreach(HollyWaterDbDataSet.BarsRow r in table.AsEnumerable().OrderBy(x => x.Total_average).Take((int)barFilter.FilterMinValue))
                    {
                        table.RemoveBarsRow(r);
                        temp.Rows.Add(r);
                    }
                    barsTableAdapter.Fill(temp);
                }
                else
                {

                }
            }
        }

        private void toolStripResetFilterButton_Click(object sender, EventArgs e)
        {
            toolStripFilterButton.BackColor = toolStripResetFilterButton.BackColor;

            BarList_Load(this, new EventArgs());
        }

        private void BarList_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ParentFormClosed != null)
                this.ParentFormClosed();
        }
    }
}
