using System;
using System.Windows.Forms;
using System.Threading;

namespace holy_water
{
    public partial class Form1 : Form
    {
        Thread th;
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {   if (checkBox1.CheckState == CheckState.Checked)
            {
                th = new Thread(opennewform);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
            }
            else
            {
                DialogResult result1 = MessageBox.Show("Are you 18+ years old?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.None,
    MessageBoxDefaultButton.Button2);
                if (result1 == DialogResult.Yes)
                {
                    MessageBox.Show("You are allowed to drink");
                    checkBox1.Checked = true;

                }
                else MessageBox.Show("Sorry, you are underaged");
            }
        }
        private void opennewform (object obj)
        {
            Application.Run(new Scale());
        }
        private void opennewforminput(object obj)
        {
            Application.Run(new Input());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkBox1.CheckState == CheckState.Checked)
            {
                th = new Thread(opennewforminput);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
            }
            else
            {
                DialogResult result1 = MessageBox.Show("Are you 18+ years old?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.None,
    MessageBoxDefaultButton.Button2);
                if (result1 == DialogResult.Yes)
                {
                    MessageBox.Show("You are allowed to drink");
                    checkBox1.Checked = true;

                }
                else MessageBox.Show("Sorry, you are underaged");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
