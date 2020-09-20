using System;
using System.Collections.Generic;
using System.Text;

namespace HW_17
{
    public static class StringExtantion
    {
        public static int ParseData(this string data)
        {
            int number;

            if (int.TryParse(data, out number))
            {
                return number;
            }
            else
            {
                return -1;
            }
        }
    }
}
