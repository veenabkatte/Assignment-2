using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2
{
    class MarksGrade
    {
        static void Main()
        {
            Console.WriteLine("Enter the marks");
            int marks = Convert.ToInt32(Console.ReadLine());
            if (marks > 70)
            {
                Console.WriteLine("A");

            }
            else if(marks>60)
            {
                Console.WriteLine("B");
            }
            else if (marks > 50)
            {
                Console.WriteLine("C");
            }
            else
            {
                Console.WriteLine("D");
            }

            Console.ReadLine();
        }
    }
}
