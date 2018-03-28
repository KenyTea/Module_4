using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication1.Modules;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
            int productCount = 0;
            Console.WriteLine("Pleas enter count of products");
            Int32.TryParse(Console.ReadLine(), out productCount);
            Random r = new Random();

            for (int i = 0; i < productCount; i++)
            {
                Product product = new Product();
                product.Pin = r.Next(0, 1458435);
                product.Brend = Console.ReadLine();
            }
        }
    }
}
