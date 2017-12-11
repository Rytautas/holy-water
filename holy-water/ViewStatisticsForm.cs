using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace holy_water
{
    public partial class ViewStatisticsForm : Form
    {
        List<BarAvg> barsAvg = new List<BarAvg>();

        public ViewStatisticsForm()
        {
            InitializeComponent();
            if (Properties.Settings.Default.ThemeDark)
            {
                BackgroundImage = Properties.Resources.dribbble;
            }
            else
            {
                BackgroundImage = Properties.Resources.dark1;
            }
        }

        private void ViewStatistics_Load(object sender, EventArgs e)
        {
            StatsPrep prep = new StatsPrep();
            barsAvg = prep.Read("Name.txt","Avg.txt");
            foreach (BarAvg baravg in barsAvg)
            {
                ListViewItem lvi = new ListViewItem(baravg.barName);
                lvi.SubItems.Add(baravg.barPercentage.ToString("#.##"));
                listView1.Items.Add(lvi);
            }

        }
    }
}
