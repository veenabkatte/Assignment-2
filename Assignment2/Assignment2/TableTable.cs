using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2
{
    class TableTable
    {
        static void Main()
        {
            Console.WriteLine("entr the number the table u want");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= 10; i++) 
            {
                Console.WriteLine(num * i);  
            }
            Console.ReadLine();
        }
    }
}
