using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lesson9
{
     public static class MyExtension
     {
            public static bool IsValidEMailAddress(this string s)
            {
                Regex regex = new Regex(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$");
                return regex.IsMatch(s);
            }
        public static int WordCount(this string s,char symbol)
        {
            int count = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == symbol) count++;
            }
            return count;
        }
     }
}
