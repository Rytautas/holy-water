using System;
using System.Collections;
using System.IO;
using System.Windows.Forms;

namespace holy_water
{
    public partial class Input : Form
    {
        ArrayList bars = new ArrayList(1);
        public class Bar
        {
            public String name;
            public double volume;
            public int percentage;
            public double locX, locY;
        }

        public Input()
        {
            InitializeComponent();
        }

        private void Input_Load(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("Bar_data.txt");
            string line = sr.ReadLine();
            while (line != null)
            {
                string[] split = line.Split(' ');
                Bar temp = new Bar();
                temp.name = split[0];
                comboBox1.Items.Add(split[0]);
                temp.volume = Convert.ToDouble(split[1]);
                temp.percentage = Int32.Parse(split[2]);
                temp.locX = Convert.ToDouble(split[3]);
                temp.locY = Convert.ToDouble(split[4]);
                bars.Add(temp);
                line = sr.ReadLine();
            }
            sr.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Bar bar = new Bar
            {
                name = textBox1.Text,
                volume = Convert.ToDouble(textBox2.Text),
                percentage = Int32.Parse(textBox3.Text),
                locX = Convert.ToDouble(textBox5.Text),
                locY = Convert.ToDouble(textBox6.Text)
            };
            // needs to handle exceptions thrown, when fields are left empty

            comboBox1.Items.Add(bar.name);
            bars.Add(bar);
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
            StreamWriter reset = new StreamWriter("Bar_data.txt");
            reset.Write("");
            reset.Close();

            StreamWriter wr = new StreamWriter("Bar_data.txt", true);
            foreach(Bar a in bars)
            {
                wr.WriteLine(a.name + " " + a.volume + " " + a.percentage + " " + a.locX + " " + a.locY);
            }
            wr.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bars.RemoveAt(comboBox1.SelectedIndex);
            comboBox1.Items.RemoveAt(comboBox1.SelectedIndex);
        }
    }
}