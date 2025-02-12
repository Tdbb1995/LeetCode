using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading;
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

    internal class arrayexamples
    {
        public int FindMaxConsecutiveOnes(int[] nums)
        {
            int maxones = 0;
            int count = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 1)
                {
                    count++;
                }
                else
                {
                    if (maxones < count)
                    {
                        maxones = count;
                    }
                    count = 0;
                }
                if(i == nums.Length - 1)
                {
                    if (maxones < count)
                    {
                        maxones = count;
                    }
                }
            }
            return maxones;
        }

        public int FindNumbers(int[] nums)
        {
            //determine if number has an even number of digits
            int count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
               if(nums[i].ToString().Length % 2 == 0)
                {
                    count++;
                }
            }
            return count;
        }

        public int[] SortedSquares(int[] nums)
        {
            int[] sortedarray = new int[nums.Length];
            int j = nums.Length - 1;
            int i = 0;
            for (int k = nums.Length-1 ; k >= 0; k--)
            {
                if(i == j)
                {
                    sortedarray[k] = nums[i] * nums[i];
                    break; 
                }
                int a = nums[i] * nums[i];
                int b = nums[j] * nums[j];
                if (a < b)
                {
                    sortedarray[k] = b;
                    j--;
                }
                else
                {
                    sortedarray[k] = a;
                    i++;
                }
                
            }
            return sortedarray;
        }

        public void DuplicateZeros(int[] arr)
        {
            int length = arr.Length;

            for (int i = 0; i < length; i++)
            {
                if (arr[i] == 0)
                {
                    for(int j = length-1; j > i; j--)
                    {
                        arr[j] =arr[j - 1];
                    }
                    i++;
                }
            
            }
        }

        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int ncount = 0;
            int mcount = 0;
            int[] temp1 = new int[nums1.Length];
            nums1.CopyTo(temp1, 0);

            for (int i = 0; i < m + n; i++)
            {
                if (mcount == m && ncount != n)
                {
                    nums1[i] = nums2[ncount];
                    ncount++;
                }
                else if (ncount == n && mcount != m)
                {
                    nums1[i] = temp1[mcount];
                    mcount++;
                }
                else
                {
                    if (temp1[mcount] <= nums2[ncount])
                    {
                        nums1[i] = temp1[mcount];
                        mcount++;
                    }
                    else
                    {
                        nums1[i] = nums2[ncount];
                        ncount++;
                    }
                }
            }

        }
    }
}
