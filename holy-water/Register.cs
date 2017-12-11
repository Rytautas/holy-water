using holy_water.Resources;
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
            Lazy<List<User>> users = new Lazy<List<User>>(() => new List<User>(prep.ReadUser(Resource1.UserDataFile)));

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
                            MessageBox.Show(Resource1.UsernameTaken);
                            match = true;
                            break;
                        }
                    }
                    if(!match)
                    {
                        IHashService hash;
                        HashService.HashServiceClient client = new HashService.HashServiceClient();

                        if (client != null)
                        {
                            hash = new HashNonLocal();
                        }
                        else
                        {
                            hash = new HashLocal();
                        }
   
                        prep.Write(Resource1.UserDataFile, user, hash);
                        MessageBox.Show(Resource1.UserCreated);
                        Close();
                    }
                }
                else
                {
                    MessageBox.Show(Resource1.PasswordsDontMatch);
                }
            }
            else
            {
                MessageBox.Show(Resource1.AgeDenied);
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }
    }
}
