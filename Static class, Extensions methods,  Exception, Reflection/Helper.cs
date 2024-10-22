 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Static_class__Extensions_methods___Exception__Reflection
{
    internal static class Helper
    {
        public static bool IsOdd(this int num)
        {
            if (num > 0 && num % 2 == 1)
            {
                return true;
            }
            return false;
        }
        public static bool IsEven(this int num)
        {
            if (num > 0 && num % 2 == 0)
            {
                return true;
            }
            return false;
        }
        public static bool HasDigit(this string value)
        {
            foreach(char c in value)
            {
                if(char.IsDigit(c))
                    return true;
            }
            return false;


        }
       public static bool CheckPassword(this string value)
        {
            if (value.Length < 8)
                return false;

            bool hasDigit = false;
            bool hasUpper = false;

            foreach (char c in value)
            {
                if (char.IsDigit(c))
                {
                    hasDigit = true;
                }

                if (char.IsUpper(c))
                {
                    hasUpper = true;
                }

                if (hasDigit && hasUpper)
                {
                    return true;
                }
            }

            return false;
        }
        public static  string Capitalize(this string value)
        {
            return value.Substring(0, 1).ToUpper() + value.Substring(1).ToLower();
        }


    }
}

