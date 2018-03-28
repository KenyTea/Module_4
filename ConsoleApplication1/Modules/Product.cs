using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Modules
{
    public class Product
    {
        public Product(): this("") {}
        public Product(string Pin):this(Pin,"") {}
        public Product(string Pin, string Brend) {}



        public string Pin { get; set; } // prop and double tab
        public string Brend { get; set; }
        public string Name { get; set; }
        public bool Analog { get; set; }
        public string ArtId { get; set; }

        private double Price_;
        public double Price
        {
            get { return Price_; }
            set
            {
                if (value > 0)
                {
                    Price_ = value;
                }
                else
                    Price_ = 0;

                //(value > )? Price_ = value : Price_ = 0;
            }
        }

        public static void PrintInfo (List<Product> products)
        {
            foreach (Product item in products)
            {
                int count = 1;
                string info = string.Format("# {0} Pin: {1}  \tBrend: {2} \tName {3}", count, item.Pin, item.Brend, item.Name);
                Console.WriteLine(info);
                count++;
            }
        }
    }
}
