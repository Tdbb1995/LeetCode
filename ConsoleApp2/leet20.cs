using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class leet20
    {

        public void tempp()
        {
            /*
            bool output = false;
            string s = ")";
            StringBuilder sb = new StringBuilder();
            Dictionary<string, string> lefthandkeys = new Dictionary<string, string>();
            lefthandkeys.Add(")","(");
            lefthandkeys.Add("}", "{");
            lefthandkeys.Add("]", "[");
            foreach (char item in s)
            {
                if (lefthandkeys.ContainsValue(item.ToString()))
                {
                    sb.Append(item);
                }
                else
                {
                    lefthandkeys.TryGetValue(item.ToString(), out string lo);
                    if (sb.ToString().EndsWith(lo))
                    {
                        sb.Remove(sb.Length - 1, 1);
                    }
                    else
                    {
                        if (lefthandkeys.Keys.Any(x => x.Equals(item.ToString())))
                        {
                            break;
                        }
                    }

                    break;
                }
                
            }
            if (sb.Length == 0)
                output = true;
            */

            //* Better answer using stack, never seen this before.
            var k = new Stack<char>();
            string s = "(({}))";
            foreach (char c in s)
            {
                if (c == '(') { k.Push(')'); continue; }
                if (c == '{') { k.Push('}'); continue; }
                if (c == '[') { k.Push(']'); continue; }
                if (k.Count == 0 || c != k.Pop()) ;// return false;

                //return k.Count == 0;



            }
        }
    }
}
