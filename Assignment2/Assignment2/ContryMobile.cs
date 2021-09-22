using System;
using System.Collections;


namespace Assignment2
{
    class ContryMobile
    {
        static void Main()
        {
            Hashtable h = new Hashtable();
            h.Add("India",91);
            h.Add("Indonesia", 62);
            h.Add("Iran", 98);
            h.Add("Iraq", 964);
            h.Add("Bhuthan", 965);
            foreach(var key in h.Keys)
            {
                Console.WriteLine($"{key} ->{h[key]}");

            }
            Console.ReadLine();

        }
    }
}
