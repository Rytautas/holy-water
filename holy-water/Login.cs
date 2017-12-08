using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace holy_water
{
    public partial class Login : Form
    {
        public delegate int HashCode(string pw);
        public Login()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            bool match = false;
            FilePrep prep = new FilePrep();
            List<User> users = new List<User>(prep.ReadUser("UserData.txt"));
            User user = new User(UsernameTextBox.Text, PasswordTextBox.Text);
#if DEBUG
            HashCode hash = delegate (string pw) { return HashPw(pw); };
#endif

#if DEBUG_SERVICE
            HashService.HashServiceClient client = new HashService.HashServiceClient();
            HashCode hash = delegate (string pw) { return client.HashPassword(pw); };
#endif

            foreach (User u in users)
            {
                if(u.Username == user.Username && Int32.Parse(u.Password) == hash(user.Password))
                {
                    MainMenu menu = new MainMenu(u);
                    match = true;
                    menu.Show();
                }
            }
            if(!match)
            {
                MessageBox.Show("Wrong username and/or password");
            }
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            Register reg = new Register();
            reg.Show();
        }

        private int HashPw(string pw)
        {
            unchecked
            {
                int hash1 = 5381;
                int hash2 = hash1;

                for (int i = 0; i < pw.Length && pw[i] != '\0'; i += 2)
                {
                    hash1 = ((hash1 << 5) + hash1) ^ pw[i];
                    if (i == pw.Length - 1 || pw[i + 1] == '\0')
                        break;
                    hash2 = ((hash2 << 5) + hash2) ^ pw[i + 1];
                }

                return hash1 + (hash2 * 1566083941);
            }
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

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
