using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Modules
{
    public class Product
    {
        public Product(): this(0) {}
        public Product(int Pin):this(Pin,"") {}
        public Product(int Pin, string Brend) {}



        public int Pin { get; set; } // prop and double tab
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
    }
}
