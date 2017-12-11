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
    public partial class EditBar : Form
    {
        public string BarName { get => this.txtName.Text; set => this.txtName.Text = value; }
        public string BarAddress { get => this.txtAddress.Text; set => this.txtAddress.Text = value; }
        public string BarCoordinates { get => this.txtCoordinates.Text; set => this.txtCoordinates.Text = value; }

        public EditBar()
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
            if (!ValidValues())
                return;

            this.Hide();
            this.DialogResult = DialogResult.OK;
        }

        private bool ValidValues()
        {
            if (txtName.Text == string.Empty)
            {
                MessageBox.Show(Resource1.EmptyFields);
                txtName.Focus();
                return false;
            }

            if (txtAddress.Text == string.Empty)
            {
                MessageBox.Show(Resource1.EmptyFields);
                txtAddress.Focus();
                return false;
            }

            return true;
        }

        private void EditBar_Load(object sender, EventArgs e)
        {

        }
    }

    
}
