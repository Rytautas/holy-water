using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace holy_water
{
    class LoadForm
    {
      public void openivedimas()
        {
            Ivedimas iv = new Ivedimas();
            iv.Show();
        }
      public void openskale()
        {
            Skale sk = new Skale();
            sk.Show();
        }
    }
}
