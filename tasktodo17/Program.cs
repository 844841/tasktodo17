using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tasktodo17
{
    class Program
    {
        static void Main(string[] args)
        {
            Product p1 = new Product { Id = 1234, Name = "SMX", Price = 456.12 };
            Product p2 = new Product { Id = 1245, Name = "FGX", Price = 523.12 };
            Product p3 = new Product { Id = 1424, Name = "LKX", Price = 4786.12 };

            var g = new Gencl<Product>();
            g[0] = p1;
            g[1] = p2;
            g[2] = p3;


            Console.WriteLine("{0} {1} {2}\n", g[0].Id, g[0].Name, g[0].Name);
            Console.Read();

        }


    }
}
