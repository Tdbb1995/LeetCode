using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class leet14
    {
        /*
        static void Main(string[] args)
        {
            /*
            //string[] strs = { "flower", "flow", "flight" };
            string[] strs = { "a"};
            strs = strs.OrderBy(x => x.Length).ToArray();
            char[] letterarray =strs.Length>0 && strs[0].Length>0? strs[0].ToCharArray(): null; //assumption is safe because condition set is that length is always >=1
                                                                                //use 1st prefix becuase it has to be true for all so easiest start point is the 1st
            string prefix = "";
            for (int i = 0; i <= letterarray.Length; i++)
            {
                if (strs.All(x => x.StartsWith(prefix, StringComparison.OrdinalIgnoreCase)) )
                {
                    if (strs.Any(x => x.Length == i))
                    {
                        break;
                    }

                        prefix = prefix + letterarray[i];
                }
                else
                {
                    prefix = prefix.Remove(prefix.Length - 1, 1);
                    break;
                }
                
            }

        }
            
            //faster method below not mine but neat.
            string[] strs = { "flower", "flow", "flight" };
            if (strs.Length < 0)
            { }
            //return "";
            var sb = new StringBuilder();
            var newIndex = 0;

            while (true)
            {
                if (newIndex >= strs[0].Length)
                    goto quitOuterLoop;

                foreach (var str in strs)
                {
                    if (newIndex >= str.Length || str[newIndex] != strs[0][newIndex])
                        goto quitOuterLoop;
                }

                sb.Append(strs[0][newIndex++]);
            }
        quitOuterLoop:;
            //return sb.ToString();
            
        }
        */
    }
}
