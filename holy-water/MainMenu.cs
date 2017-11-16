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
            checkBox1.Checked = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Average avg = new Average();
            LoadForm loadstats = new LoadForm();
            loadstats.openstats();
        }
    }
}
