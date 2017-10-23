using holy_water.Resources;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace holy_water
{
    public partial class Input : Form
    {
        List<Bar> bars = new List<Bar>();
        public List<Bar> selectedBars;

        public Input()
        {
            InitializeComponent();
        }

        private void Input_Load(object sender, EventArgs e)
        {
            FilePrep filePrep = new FilePrep();
            bars = filePrep.Read(Resource1.FileName);
            foreach(Bar bar in bars)
            {
                comboBox1.Items.Add(bar.name);
            }
            comboBox1.SelectedIndex = 0;
            panel2.Hide();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrEmpty(textBox2.Text) && !string.IsNullOrEmpty(textBox3.Text)&& !string.IsNullOrEmpty(textBox5.Text)&& !string.IsNullOrEmpty(textBox6.Text))
            {
                try {
                    Bar newBar = new Bar(textBox1.Text, textBox2.Text.ToDouble(), textBox5.Text.ToDouble(), textBox6.Text.ToDouble(), Int32.Parse(textBox3.Text));
                    bool match = false;
                    foreach (Bar bar in bars)
                    {
                        if(bar.name == newBar.name)
                        {
                            bar.CountAverage(newBar);
                            match = true;
                        }
                    }
                    if(match != true)
                    {
                        comboBox1.Items.Add(newBar.name);
                        bars.Add(newBar);
                    }
                }
                catch(FormatException ex)
                {
                    MessageBox.Show(Resource1.NonNumeric);
                }
            }
            else
            {
                MessageBox.Show(Resource1.EmptyFields);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Bar bar = bars[comboBox1.SelectedIndex];
            textBox1.Text = bar.name;
            textBox2.Text = bar.volume.ToString("F2");
            textBox3.Text = bar.percentage.ToString("F2");
            textBox5.Text = bar.locX.ToString("F2");
            textBox6.Text = bar.locY.ToString("F2");
            textBox4.Text = bar.Average.ToString("F2");
        }
        
        private void SaveToFile_Click(object sender, EventArgs e)
        {
            FilePrep filePrep = new FilePrep();
            filePrep.Write(Resource1.FileName, bars);
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            if (comboBox1.Items.Count == 0)
            {
                MessageBox.Show(Resource1.EmptyList);
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

        public void FilterButtonClick(object sender, EventArgs e)
        {
            panel2.Show();

            if (!FilterComboBox.Items.Contains("Filter by percentage") && !FilterComboBox.Items.Contains("Filter by average"))
            {
                FilterComboBox.Items.Add("Filter by percentage");
                FilterComboBox.Items.Add("Filter by average");
                FilterComboBox.SelectedIndex = 0;
            }
        }

        private void ResetFilter_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            foreach(Bar bar in bars)
            {
                comboBox1.Items.Add(bar.name);
                comboBox1.SelectedIndex = 0;
            }
        }

        private void DataFilter_Click(object sender, EventArgs e)
        {
            Filter filter = new Filter();
            int index = FilterComboBox.SelectedIndex;
            List<Bar> selectedBars = filter.FilterCondition(index, bars);
            if(selectedBars == null || selectedBars.Count == 0)
            {
                MessageBox.Show(Resource1.ReturnEmpty);
            }
            else
            {
                panel2.Hide();
                comboBox1.Items.Clear();
                if(selectedBars.Count == 0)
                {
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                    textBox5.Clear();
                    textBox6.Clear();
                    MessageBox.Show("Nothing to show");
                }
                foreach(Bar bar in selectedBars)
                {
                    comboBox1.Items.Add(bar.name);
                    comboBox1.SelectedIndex = 0;
                }
                comboBox1.SelectedIndex = 0;
            }
        }

        private void BackTo_Click(object sender, EventArgs e)
        {
            panel1.Show();
            panel2.Hide();
        }
    }
}