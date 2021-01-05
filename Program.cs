using System;
using System.Collections.Generic;

namespace FindArraysWith0Sum
{
    class Program
    {
        //Print all sub-arrays with 0 sum
        //Given an array of integers, print all sub-arrays with 0 sum.
        static void Main(string[] args)
        {
            int[] numbers = { 4, 2, -3, -1, 0, 4 };
            GetSubArrays(numbers);
        }


        public static void GetSubArrays(int[] numbs)
        {
            for (int i = 0; i < numbs.Length; i++)
            {
                int sum = 0;

                for (int j = i; j < numbs.Length; j++)
                {
                    sum += numbs[j];

                    if (sum == 0)
                    {
                        Console.WriteLine($"Subarray[{i}...{j}]");
                    }
                }

            }



        }
    }
}
