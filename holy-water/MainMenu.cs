using System;
using System.Windows.Forms;

namespace holy_water
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (checkBox1.CheckState == CheckState.Checked)
            {
                LoadForm loadinput = new LoadForm();
                loadinput.openinput();
            }
            else
            {
                Underage checkage = new Underage();
                if (checkage.Msg() == true) checkBox1.Checked = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
