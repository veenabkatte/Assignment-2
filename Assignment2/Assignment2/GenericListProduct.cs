using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2
{
    class GenericListProduct
    {
        static void Main()
        {
            List<Product> product = new List<Product>
            {
                new Product{ProCode=100,ProName= "SPrestige" ,Category= "didh" },
                new Product{ ProCode = 101, ProName = "Santhoor", Category = "Soap" }
            };
            foreach (var p in product)
            {
                Console.WriteLine($"Code={p.ProCode} Name={p.ProName} Email={p.Category}");
            }
            Console.ReadLine();

        }

    }
}
