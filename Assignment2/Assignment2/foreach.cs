using System;
namespace Assignment2
{
    class @foreach
    {
        static void Main()
        {
            int[] Array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            foreach(var result in Array)
            {
                if(result%2==0)
                {
                    Console.WriteLine(result + " is Even number");
                }
                else
                {
                    Console.WriteLine(result+ "odd number");
                }
                Console.ReadLine();   
            }


        }
    }
}
