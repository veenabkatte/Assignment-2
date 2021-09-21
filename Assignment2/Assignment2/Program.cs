using System;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int number = Convert.ToInt32(Console.ReadLine());
            if(number>=0)
            {
                Console.WriteLine("it is positive number");

            }
            else
            {
                Console.WriteLine("it is a negative number");
            }
            Console.ReadLine();
        }
    }
}
