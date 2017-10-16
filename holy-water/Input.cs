using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Linq;

namespace holy_water
{
    public partial class Input : Form
    {
        List<Bar> bars = new List<Bar>();
        

        public Input()
        {
            InitializeComponent();
        }

        private void Input_Load(object sender, EventArgs e)
        {
            FilePrep filePrep = new FilePrep();
            bars = filePrep.Read("Bar_data.txt");
            foreach(Bar bar in bars)
            {
                comboBox1.Items.Add(bar.name);
            }
            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrEmpty(textBox2.Text) && !string.IsNullOrEmpty(textBox3.Text)&& !string.IsNullOrEmpty(textBox5.Text)&& !string.IsNullOrEmpty(textBox6.Text))
            {
                try {
                    Bar bar = new Bar(textBox1.Text, Convert.ToDouble(textBox2.Text), Convert.ToDouble(textBox5.Text), Convert.ToDouble(textBox6.Text), Int32.Parse(textBox3.Text));
                    comboBox1.Items.Add(bar.name);
                    bars.Add(bar);
                }
                catch(FormatException ex)
                {
                    MessageBox.Show("You have entered non-numeric characters");
                }
            }
            else
            {
                MessageBox.Show("Please fill all the fields");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Bar bar = (Bar) bars[comboBox1.SelectedIndex];
            textBox1.Text = bar.name;
            textBox2.Text = bar.volume.ToString("F2");
            textBox3.Text = bar.percentage.ToString();
            textBox5.Text = bar.locX.ToString("F2");
            textBox6.Text = bar.locY.ToString("F2");
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            FilePrep filePrep = new FilePrep();
            filePrep.Write("Bar_data.txt", bars);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (comboBox1.Items.Count == 0)
            {
                MessageBox.Show("There is nothing to remove");
            }
            else
            {
                bars.RemoveAt(comboBox1.SelectedIndex);
                comboBox1.Items.RemoveAt(comboBox1.SelectedIndex);
                if (comboBox1.Items.Count != 0)
                {
                    comboBox1.SelectedIndex = 0;
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Bar[] bars = this.bars.ToArray();
            Regex reg = new Regex(@"[\d]");
            string input = Interaction.InputBox("Pasirinkite min alaus lygi:");
            if(reg.IsMatch(input))
            {
                var selectedBars = from bar in bars
                                   where bar.percentage >= Int32.Parse(input)
                                   select bar;
                comboBox1.Items.Clear();
                foreach(Bar bar in selectedBars)
                {
                    comboBox1.Items.Add(bar.name);
                    comboBox1.SelectedIndex = 0;
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            foreach(Bar bar in bars)
            {
                comboBox1.Items.Add(bar.name);
                comboBox1.SelectedIndex = 0;
            }
        }
    }
}