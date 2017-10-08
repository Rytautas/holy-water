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
      public void openinput()
        {
            Input iv = new Input();
            iv.Show();
        }
      public void openscale()
        {
            Scale sk = new Scale();
            sk.Show();
        }
    }
}
