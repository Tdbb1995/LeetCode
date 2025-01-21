using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Leet9
    {
        public bool IsPalindrom(int x)
        {
            string xasstring = x.ToString();
            char[] xasarray = xasstring.ToArray();

            char[] reverse = xasarray.Reverse().ToArray();

            string reversestring = "";
            for (int i = 0; i < reverse.Length; i++)
            {
                reversestring += reverse[i];
            }

            if (xasstring == reversestring)
            {
                return true;
            }
            else
            {
                return false;
            }




        }

    }
}
