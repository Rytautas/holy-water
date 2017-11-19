using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace holy_water
{
    public partial class BarList : Form
    {

        public event OnBarChanged BarChanged;
        public delegate void OnBarChanged(int barId, string barName);


        private bool reload = false;

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
            this.barsTableAdapter.Fill(this.hollyWaterDbDataSet.Bars);
            Enable_buttons();
            
        }

        private void Enable_buttons()
        {
            bindingNavigatorDeleteItem.Enabled = bindingNavigatorPositionItem.Enabled;
            bindingNavigatorViewDrinksItem.Enabled = bindingNavigatorPositionItem.Enabled;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            using (EditBar editBar = new EditBar())
            {
                editBar.Text = "New Bar";
                if (editBar.ShowDialog() == DialogResult.OK)
                {
                    DataRow row = ((DataRowView)this.barsBindingSource.Current).Row;
                    row["Name"] = editBar.BarName;
                    row["Address"] = editBar.BarAddress;
                    row["Map_coordinates"] = editBar.BarCoordinates != string.Empty ? editBar.BarCoordinates : null;
                    row["Total_average"] = 0.00;
                    row["Total_count"] = 0;

                    this.barsBindingSource.EndEdit();
                    this.barsTableAdapter.Update(this.hollyWaterDbDataSet.Bars);
                }
                else
                {

                    barsBindingSource.CancelEdit();
                }

            }


        }


        private void barsBindingSource_AddingNew(object sender, AddingNewEventArgs e)
        {
         }

        private void dataGridView2_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (MessageBox.Show("Do you want to delete?", "Warning", MessageBoxButtons.YesNo) == DialogResult.No)
                e.Cancel = true;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
                editBar.Text = "Edit Bar";
                DataRow row = ((DataRowView)this.barsBindingSource.Current).Row;
                editBar.BarName = row["Name"].ToString();
                editBar.BarAddress = row["Address"].ToString();
                editBar.BarCoordinates = row["Map_coordinates"].ToString();


                if (editBar.ShowDialog() == DialogResult.OK)
                {


                    row["Name"] = editBar.BarName;
                    row["Address"] = editBar.BarAddress;
                    row["Map_coordinates"] = editBar.BarCoordinates != string.Empty ? editBar.BarCoordinates : null;
                    row["Total_average"] = 0.00;


                    this.barsBindingSource.EndEdit();
                    this.barsTableAdapter.Update(this.hollyWaterDbDataSet.Bars);
                }
            }

        }

        private void barsBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            if (reload) return;

            Enable_buttons();
 
            DataRow row = ((DataRowView)this.barsBindingSource.Current).Row;

            if (this.BarChanged != null)
                BarChanged(int.Parse(row["Id"].ToString()), row["Name"].ToString());

        }

        private void bindingNavigatorViewDrinksItem_Click(object sender, EventArgs e)
        {

            DataRow row = ((DataRowView)this.barsBindingSource.Current).Row;
            DrinkList drinkList = new DrinkList(int.Parse(row["Id"].ToString()), row["Name"].ToString());
            this.BarChanged += drinkList.OnBarChanged;
            drinkList.DrinkChanged += DrinkList_DrinkChanged;
            drinkList.Show();
        }

        private void DrinkList_DrinkChanged(int barId)
        {
            reload = true;
            int currentRow = dataGridView2.CurrentCell.RowIndex;
            this.barsTableAdapter.Fill(this.hollyWaterDbDataSet.Bars);

            dataGridView2.Rows[currentRow].Selected = true;
            dataGridView2.Refresh();
            Enable_buttons();
           reload = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
            
        }

        private void btnResetFilter_Click(object sender, EventArgs e)
        {
            
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
           
        }
    }
}
