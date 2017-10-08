using System;
using System.Windows.Forms;

namespace holy_water
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoadForm test = new LoadForm();
            test.openivedimas();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.CheckState == CheckState.Checked)
            {
                LoadForm loadskale = new LoadForm();
                loadskale.openskale();
            }
            else
            {
                Underage checkage = new Underage();
                if (checkage.Msg() == true) checkBox1.Checked = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkBox1.CheckState == CheckState.Checked)
            {
                LoadForm loadivedimas = new LoadForm();
                loadivedimas.openivedimas();
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
    }
}
