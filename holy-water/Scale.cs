using System;
using System.IO;
using System.Windows.Forms;

namespace holy_water
{
    public partial class Scale : Form
    {
        public Scale()
        {
            InitializeComponent();
        }

        private void Scale_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {   
            this.Close();
        }
        private void opennewform(object obj)
        {
            Application.Run(new Form1());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamWriter sw = File.AppendText("text.txt");
            sw.WriteLine(textBox1.Text);
            sw.Flush();
            sw.Close();
        }
    }
}