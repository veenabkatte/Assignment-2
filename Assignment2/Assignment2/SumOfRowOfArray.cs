using System;
using System.Collections;


namespace Assignment2
{
    class SumOfRowOfArray
    {
        static void Main(string[] args)
        {
            int[,] a = new int[3, 3];
            int sum = 0;
            Console.WriteLine("enter the m*n numbers:");
            for (int i = 0; i < 3; i++) 
            {
                for(int j=0;j<3;j++)
                {
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    sum = sum + a[i, j];
                }
                Console.WriteLine($"sum of indivisual row is {sum}");
                sum = 0;
            }
            Console.ReadLine();

        }
    }
}
