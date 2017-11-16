using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace holy_water
{
    public partial class Login : Form
    {
        
        public Login()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            bool match = false;
            FilePrep prep = new FilePrep();
            List<User> users = new List<User>(prep.ReadUser("UserData.txt"));
            User user = new User(PasswordTextBox.Text, UsernameTextBox.Text);

            foreach(User u in users)
            {
                if(u.Username == user.Username && u.Password == user.Password)
                {
                    MainMenu menu = new MainMenu();
                    match = true;
                    menu.Show();
                }
            }
            if (!match)
            {
                MessageBox.Show("Wrong username and/or password");
            }
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            Register reg = new Register();
            reg.Show();
        }

        private string HashToString(int hashCode)
        {
            return "Success";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PasswordTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                LoginButton_Click(sender, e);
            }
        }
    }
}
