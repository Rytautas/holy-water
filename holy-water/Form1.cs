﻿using System;
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
            else MessageBox.Show("Are you 18+ years old?");
        }
        private void opennewform (object obj)
        {
            Application.Run(new Skale());
        }
        private void opennewformivedimas(object obj)
        {
            Application.Run(new Ivedimas());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkBox1.CheckState == CheckState.Checked)
            {
                th = new Thread(opennewformivedimas);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
            }
            else MessageBox.Show("Are you 18+ years old?");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
