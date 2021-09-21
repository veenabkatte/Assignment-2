using System;


namespace Assignment2
{
    class Class1
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
