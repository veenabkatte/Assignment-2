using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2
{
    class SumOfArray
    {
        static void Main()
        {
            int[] num = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine("\nArray1:[{0}]", string.Join(",", num));
            var sum = 0;
            for(var i=0;i<num.Length;i++)
            {
                sum += num[i];
            }
            Console.WriteLine("sum: " + sum);
        }
    }
}
