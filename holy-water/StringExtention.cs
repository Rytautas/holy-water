using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace holy_water
{
    public static class StringExtention
    {
        public static double ToDouble(this string str)
        {
            return Convert.ToDouble(str);
        }
    }
}
