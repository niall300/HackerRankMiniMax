using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Given five positive integers,  
//    find the minimum and maximum values that can be calculated
//    by summing exactly four of the five integers.
//    Then print the respective minimum and maximum values 
//    as a single line of two space-separated long integers.

//Input Format

//A single line of five space-separated integers.
namespace MiniMaxSum
{
    class Solution
    {
        static void Main(string[] args)
        {
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
            MiniMaxSum(arr);
            Console.ReadLine();
        }

        static void MiniMaxSum(int[] myArray)
        {
            //sum the array 
            Int64 sum = 0;
            for (int i = 0; i < myArray.Length; i++)
            {
                sum = sum + myArray[i];

            }
            Int64 max = 0;
            Int64 min = Int64.MaxValue;
            Int64 runningTotal= 0;
            //now we subtract each index and compare to max and min
            for (int i = 0; i < myArray.Length; i++)
            {

                runningTotal = sum - myArray[i];

                if(runningTotal >= max)
                {
                    max = runningTotal;

                } 
                if(runningTotal <= min)
                {
                    min = runningTotal;
                }
            }

            //print min and max
            Console.WriteLine("{0} {1}",min, max);

        }
    }
}
