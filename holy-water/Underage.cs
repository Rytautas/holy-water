using holy_water.Resources;
using System.Windows.Forms;

namespace holy_water
{
    class Underage
    {
        public bool Msg()
        {   
            DialogResult result1 = MessageBox.Show(Resource1.AgeCheck, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.None,
            MessageBoxDefaultButton.Button2);
            if (result1 == DialogResult.Yes)
            {
                MessageBox.Show(Resource1.AgeAllowed);
                return true;
            }
            else MessageBox.Show(Resource1.AgeDenied);
            return false;
        }
    }
}
