using System;

namespace holy_water
{
    public static class StringExtention
    {
        public static decimal ToDecimal(this string str)
        {   

            try
            {
                return Convert.ToDecimal(str);
            }
            catch (OverflowException e)
            {
                MessageBox.Show("Some of the data has been shortened because it is too long " + e);
                int lengthMax = (Decimal.MaxValue).ToString().Length;
                return Convert.ToDecimal(str.Substring(0, Math.Min(str.Length, lengthMax)));
            }
        }
    }
}
