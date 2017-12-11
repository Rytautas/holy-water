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
    public partial class InputDrinkForm : Form
    {

        public DateTime DrinkTime { get => dtpDrinkTime.Value; }
        public decimal GlassVolume { get => txtGlassVolume.Value; }
        public int FillPercentage { get => this.trkFillPercentage.Value;  }

        public InputDrinkForm()
        {
            InitializeComponent();

        }

        private void InputDrink_Load(object sender, EventArgs e)
        {
            lblFillPercentage.Text = string.Format("{0}%", trkFillPercentage.Value);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.DialogResult = DialogResult.OK;
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            lblFillPercentage.Text = string.Format("{0}%", trkFillPercentage.Value);
        }
    }
}
