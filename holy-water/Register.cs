using HolyWaterWebService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace holy_water
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            FilePrep prep = new FilePrep();
            Lazy<List<User>> users = new Lazy<List<User>>(() => new List<User>(prep.ReadUser("UserData.txt")));

            if(checkBox18.Checked)
            {
                if(PasswordTextBox.Text == RepeatPassword.Text)
                {
                    bool match = false;
                    User user = new User(usernameTextBox.Text, PasswordTextBox.Text);
                    foreach(User u in users.Value)
                    {
                        if(u.Username.Equals(user.Username))
                        {
                            MessageBox.Show("This username already exists");
                            match = true;
                            break;
                        }
                    }
                    if(!match)
                    {
                        prep.Write("UserData.txt", user);
                        MessageBox.Show("User created successfully");
                        Close();
                    }
                }
                else
                {
                    MessageBox.Show("Passwords must match");
                }
            }
            else
            {
                MessageBox.Show("You must be +18 years old to proceed");
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private int HashPw(string pw)
        {
            return 0;
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }
    }
}
