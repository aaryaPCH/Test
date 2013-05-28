using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    static class StringExtensions
    {
        public static bool IsNullOrEmptyAfterTrim(this string inputString)
        {
            return inputString == null || inputString.Trim() == string.Empty;
        }

        public static int GetLength(this string str)
        {
            return str == null ? 0 : str.Length;
        }

        public static int GetSumOfAsciiCodes(this string str)
        {
            if (str == null) return 0;
            var sum = 0;
            foreach (var eachChar in str)
            {
                sum += eachChar;
            }

            return sum;
        }
    }
}
