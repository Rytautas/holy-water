using System;
using System.Windows.Forms;

namespace holy_water
{
    public partial class MainMenuForm : Form
    {
        User user;
        public MainMenuForm(User user)
        {
            InitializeComponent();
            this.user = user;
            Properties.Settings.Default.ThemeDark = user.dark;
            if(!Properties.Settings.Default.ThemeDark)
            {
                BackgroundImage = Properties.Resources.dribbble;
            }
            else
            {
                BackgroundImage = Properties.Resources.dark1;
                DarkThemeSwitch.Checked = true;
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (checkBox1.CheckState == CheckState.Checked)
            {
                // LoadForm loadinput = new LoadForm();
                // loadinput.openinput();
                LoadForm loadbarList = new LoadForm();
                loadbarList.openinput();
            }
            else
            {
                Underage checkage = new Underage();
                if (checkage.Msg() == true) checkBox1.Checked = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            checkBox1.Checked = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

      /*  private void button1_Click_1(object sender, EventArgs e)
        {
            Average avg = new Average();
            LoadForm loadstats = new LoadForm();
            loadstats.openstats();
        }
        */
        private void DarkThemeSwitch_CheckedChanged(object sender, EventArgs e)
        {
            FilePrep prep = new FilePrep();
            if (DarkThemeSwitch.Checked)
            {
                BackgroundImage = Properties.Resources.dark1;
                Properties.Settings.Default.ThemeDark = true;
                Properties.Settings.Default.Save();
                prep.Write("UserData.txt", user);
            }
            else
            {
                BackgroundImage = Properties.Resources.dribbble;
                Properties.Settings.Default.ThemeDark = false;
                Properties.Settings.Default.Save();
                prep.Write("UserData.txt", user);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            (new BarListForm()).ShowDialog();
        }
    }
}
