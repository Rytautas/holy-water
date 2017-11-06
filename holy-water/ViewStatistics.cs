using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace holy_water
{
    public partial class ViewStatistics : Form
    {
        List<BarAvg> barsAvg = new List<BarAvg>();

        public ViewStatistics()
        {
            InitializeComponent();
        }

        private void ViewStatistics_Load(object sender, EventArgs e)
        {
            StatsPrep prep = new StatsPrep();
            barsAvg = prep.Read("test.txt");
            foreach (BarAvg baravg in barsAvg)
            {
                ListViewItem lvi = new ListViewItem(baravg.barName);
                lvi.SubItems.Add(baravg.barPercentage.ToString("#.##"));
                listView1.Items.Add(lvi);
            }

        }
    }
}
