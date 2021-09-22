using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2
{
    class SumOfDiagonal
    {
        static void Main()
        {
            int[,] a = { { 10, 40, 50 }, { 60, 20, 70 }, { 80, 90, 30 } };
            int sum1 = 0;
            for (int i = 0; i < 3; i++) 
            {
                for (int j = 0; j < 3; j++)
                {
                    if(i==j)
                    {
                        sum1 = sum1 + a[i, j];
                    }
                }
            }
            Console.WriteLine(sum1);
            Console.ReadLine();
        }
       
    }
}
