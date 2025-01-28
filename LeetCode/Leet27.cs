using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class Leet27
    {
        public int RemoveElement(int[] nums, int val)
        {   //val = 3 nums 3 2 2 3
            //             i     j
            int k = 0;
            int j = nums.Length-1;

            for (int i = 0;i <nums.Length && i <= j;i++)
            {
                if (nums[i] == val)
                {
                    while (nums[j] == val && j > i && j > 0)
                    {
                        nums[j] = val;
                        j--;

                    }
                    if(j > i)
                    {
                        k++;
                        nums[i] = nums[j];
                        nums[j] = val;
                    }

                }
                else
                {
                    k++;
                }
            }

            return k;
        }
    }
}
