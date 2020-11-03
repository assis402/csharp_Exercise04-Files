using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Qts { get; set; }

        public Product(string name, double price, int qts)
        {
            Name = name;
            Price = price;
            Qts = qts;
        }

        public double Total()
        {
            return Qts * Price;
        }
    }






}
