using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2
{
    class EvenWhile
    {
        static void Main()
        {
            int number;
            
            number = 1;
            Console.WriteLine("Enter the value of the N");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine( n);
            while(number<=n)
            {
                if (number %2== 0)
                    Console.WriteLine( number);
                number++;
            }
            Console.ReadLine();
        }
    }
}
