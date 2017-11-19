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
            FilteByAverage,
            FilterByCount
        }

        public FilterType Filter {
            get => rdbFilterByAverage.Checked ? FilterType.FilteByAverage : FilterType.FilterByCount;
            set
            {
                rdbFilterByAverage.Checked = value == FilterType.FilteByAverage;
                rdbFilterByCount.Checked = value == FilterType.FilterByCount;
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
                MessageBox.Show("Invalid minimum value.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMinimumValue.Focus();
                return false;
            }

            int i;
            if (rdbFilterByCount.Checked && !int.TryParse(txtMinimumValue.Text, out i))
            {
                MessageBox.Show("Invalid minimum value.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMinimumValue.Focus();
                return false;
            }

            return true;
        }
    }
}
