using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = { 4, 0, 0, 0, 0, 0 };
            int m = 1, n = 5;
            int[] nums2 = { 1, 2, 3,5,6 };
            arrayexamples leet = new arrayexamples();
            leet.Merge(nums1,m,nums2,n);     

        }
    }
}
