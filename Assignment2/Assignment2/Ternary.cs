using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2
{
    class Ternary
    {
        static void main()
        {
            Console.WriteLine("enter the number");
            int Number = Convert.ToInt32(Console.ReadLine());
            var result = Number >= 0 ? "It is positive" : "It is negative";
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
