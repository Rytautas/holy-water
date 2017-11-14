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
                comboBox1.Items.Add(bar.Name);
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
            if (!string.IsNullOrEmpty(txtBarName.Text) && !string.IsNullOrEmpty(txtGlassVolume.Text) && !string.IsNullOrEmpty(txtPercentage.Text)&& !string.IsNullOrEmpty(txtCoordinateX.Text)&& !string.IsNullOrEmpty(txtCoordinateY.Text))
            {
                try {
                    bool match = false;

                    for (int i = 0; i < bars.Count && !match; i++)
                    {
                        if (bars[i].Name == txtBarName.Text)
                        {
                            Bar b = bars[i];
                            b.Percentage = Int32.Parse(txtPercentage.Text);
                            txtAverage.Text = b.Average.ToString("F2");
                            bars[i] = b;
                            match = true;
                            comboBox1.SelectedIndex = i;

                        }

                    }
                    if(match != true)
                    {
                        bars.Add(new Bar(
                            txtBarName.Text, 
                            txtGlassVolume.Text.ToDouble(), 
                            txtCoordinateX.Text.ToDouble(), 
                            txtCoordinateY.Text.ToDouble(), 
                            Int32.Parse(txtPercentage.Text)
                            ));
                        comboBox1.Items.Add(txtBarName.Text);
                        comboBox1.SelectedIndex = comboBox1.Items.Count - 1;
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
            txtBarName.Text = bar.Name;
            txtGlassVolume.Text = bar.Volume.ToString("F2");
            txtPercentage.Text = bar.Percentage.ToString("D");
            txtCoordinateX.Text = bar.LocX.ToString("F2");
            txtCoordinateY.Text = bar.LocY.ToString("F2");
            txtAverage.Text = bar.Average.ToString("F2");
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

            if (!FilterComboBox.Items.Contains(Resource1.FilterConditionPerc) && !FilterComboBox.Items.Contains(Resource1.FilterConditionAvg))
            {
                FilterComboBox.Items.Add(Resource1.FilterConditionPerc);
                FilterComboBox.Items.Add(Resource1.FilterConditionAvg);
                FilterComboBox.SelectedIndex = 0;
            }
        }

        private void ResetFilter_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            foreach(Bar bar in bars)
            {
                comboBox1.Items.Add(bar.Name);
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
                    txtBarName.Clear();
                    txtGlassVolume.Clear();
                    txtPercentage.Clear();
                    txtAverage.Clear();
                    txtCoordinateX.Clear();
                    txtCoordinateY.Clear();
                    MessageBox.Show(Resource1.NothingToShow);
                }
                foreach(Bar bar in selectedBars)
                {
                    comboBox1.Items.Add(bar.Name);
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