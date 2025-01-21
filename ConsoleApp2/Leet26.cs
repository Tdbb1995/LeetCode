using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Leet26
    {

        public int RemoveDuplicates(int[] nums)
        {
            int k = 0;
            int? past = null;
            for (int i = 0; i < nums.Length; i++)
            {
                if (past != nums[i] | past == null)
                {
                    past = nums[i];
                    nums[k] = nums[i];
                    k++;
                }

            }
            return k ;





        }
    }
}
