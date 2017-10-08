using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace holy_water
{
    class Underage
    {
        public bool Msg()
        {
            DialogResult result1 = MessageBox.Show("Are you 18+ years old?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.None,
            MessageBoxDefaultButton.Button2);
            if (result1 == DialogResult.Yes)
            {
                MessageBox.Show("You are allowed to drink");
                return true;

            }
            else MessageBox.Show("Sorry, you are underaged");
            return false;
        }
    }
}
