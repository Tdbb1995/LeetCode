using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class FileName
    {
        /*
        static void Main(string[] args)
        {
            //assumptions : max value is 3999
            // Roman numerals can not use multiple values to subtract ie III = 3 IIV != 3
            //Assuming all inputs are true values for roman numerals no handling for something like IIII.
            string test = "MCMXCIV";
            char[] temp = test.ToCharArray();
            Dictionary<string, int> RomanNumerals = new Dictionary<string, int>();
            RomanNumerals.Add("I", 1);
            RomanNumerals.Add("V", 5);
            RomanNumerals.Add("X", 10);
            RomanNumerals.Add("L", 50);
            RomanNumerals.Add("C", 100);
            RomanNumerals.Add("D", 500);
            RomanNumerals.Add("M", 1000);

            int[] RomanNumeralIntArray = new int[temp.Length]; 
            for(int i = 0; i < temp.Length; i++) 
            {
                RomanNumerals.TryGetValue(temp[i].ToString(), out int value);
                RomanNumeralIntArray[i] = value;
            }
            int RomanNumeralInteger = 0;
            for(int i = 0; i <temp.Length; i++)
            {
                if(i+1 <temp.Length)
                {
                    if (RomanNumeralIntArray[i] < RomanNumeralIntArray[i+1])
                    {
                        RomanNumeralInteger += (RomanNumeralIntArray[i + 1] - RomanNumeralIntArray[i]);
                        i++; //Need to double increment to move ahead 2 values ie index 0 fast forwards to 2 +1 here +1 with each loop.
                    }
                    else
                    {
                        RomanNumeralInteger += RomanNumeralIntArray[i];
                    }
                }
                else //Should only occur on the last value
                {
                    RomanNumeralInteger += RomanNumeralIntArray[i];
                }
            }
        }\
        */
    }
}
