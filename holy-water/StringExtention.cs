using System;
using System.Windows.Forms;

namespace holy_water
{
    public static class StringExtention
    {
        public static decimal ToDecimal(this string str)
        {   
                return Convert.ToDecimal(str);
        }
    }
}
