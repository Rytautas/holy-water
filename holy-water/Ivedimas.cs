using System;
using System.Collections;
using System.Windows.Forms;


namespace holy_water
{
    public partial class Ivedimas : Form
    {
        ArrayList barai = new ArrayList(1);
        public class Baras
        {
            public String name;
            public double volume;
            public int percentage;
            public double locX, locY;
        }

        public Ivedimas()
        {
            InitializeComponent();
        }

        private void Ivedimas_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void button3_Click(object sender, EventArgs e)
        {
            Baras bar = new Baras
            {
                name = textBox1.Text,
                volume = Convert.ToDouble(textBox2.Text),
                percentage = Int32.Parse(textBox3.Text),
                locX = Convert.ToDouble(textBox5.Text),
                locY = Convert.ToDouble(textBox6.Text)
            };
            // needs to handle exceptions thrown, when fields are left empty

            comboBox1.Items.Add(bar.name);
            barai.Add(bar);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Baras bar = (Baras) barai[comboBox1.SelectedIndex];
            textBox1.Text = bar.name;
            textBox2.Text = bar.volume.ToString("F2");
            textBox3.Text = bar.percentage.ToString();
            textBox5.Text = bar.locX.ToString("F2");
            textBox6.Text = bar.locY.ToString("F2");
        }
        

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
