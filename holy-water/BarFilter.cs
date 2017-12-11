using holy_water.Resources;
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
    public partial class BarFilter : Form
    {
        public enum FilterType
        {
            FilterByAverage,
            FilterByCount,
            Top,
            Bottom
        }

        public FilterType Filter
        {
            get
            {
                if (rdbFilterByAverage.Checked || rdbFilterByCount.Checked)
                    return rdbFilterByAverage.Checked ? FilterType.FilterByAverage : FilterType.FilterByCount;
                else
                    return rdbTop.Checked ? FilterType.Top : FilterType.Bottom;
            }
            set
            {
                rdbFilterByAverage.Checked = value == FilterType.FilterByAverage;
                rdbFilterByCount.Checked = value == FilterType.FilterByCount;
                rdbTop.Checked = value == FilterType.Top;
                rdbBottom.Checked = value == FilterType.Bottom;
            }
        }

        public decimal FilterMinValue
        {
            get => decimal.Parse(txtMinimumValue.Text);
            set => txtMinimumValue.Text = string.Format("{0}", value);
        }


        public BarFilter()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (!ValidateValues())
                return;

            this.Hide();
            this.DialogResult = DialogResult.OK;
        }

        private bool ValidateValues()
        {
            double dbl;
            if (rdbFilterByAverage.Checked && !double.TryParse(txtMinimumValue.Text, out dbl))
            {
                MessageBox.Show(Resource1.InvalidMinValue, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMinimumValue.Focus();
                return false;
            }

            int i;
            if ((rdbFilterByCount.Checked || rdbTop.Checked || rdbBottom.Checked) && !int.TryParse(txtMinimumValue.Text, out i))
            {
                MessageBox.Show(Resource1.InvalidMinValue, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMinimumValue.Focus();
                return false;
            }

            return true;
        }

        private void rdbFilterByAverage_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbFilterByAverage.Checked)
            {
                label1.Text = Resource1.LabelValueMin;
            }
        }

        private void rdbFilterByCount_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbFilterByCount.Checked)
            {
                label1.Text = Resource1.LabelValueMin;
            }
        }

        private void rdbTop_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbTop.Checked)
            {
                label1.Text = Resource1.LabelValueBars;
            }
        }

        private void rdbBottom_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbBottom.Checked)
            {
                label1.Text = Resource1.LabelValueBars;
            }
        }
    }
}
