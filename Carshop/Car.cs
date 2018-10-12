using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsShop
{
    public class Car
    {
        public string Name{ get; set; }

        public string Color { get; set; }

        public double Price { get; set; }

        public double Sale { get; set; }

        public Car()
        {
            Sale  = 20;
        }

        public double GetSale() {
            return Price - (Price * Sale/100);
        }
    }
}
