﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2
{
    class DayNumber
    {
        static void Main()
        {
            Console.WriteLine("Enter the number of day");
            int DayNum = Convert.ToInt32(Console.ReadLine());
            switch(DayNum)
            {
                case 1 :Console.WriteLine("Monday");
                    break;
                case 2:Console.WriteLine("Tuesday");
                    break;
                case 3:Console.WriteLine("Wednesday");
                    break;
                case 4: Console.WriteLine("Thursday");
                    break;
                case 5:Console.WriteLine("Friday");
                    break;
                case 6:Console.WriteLine("Saturday");
                    break;
                case 7:Console.WriteLine("Sunday");
                    break;



            }
            Console.ReadLine();
        }
    }
}
