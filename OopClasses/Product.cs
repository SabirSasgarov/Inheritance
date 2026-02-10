using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopClasses
{
    internal class Product
    {
        public string Name;
        public double Price;
        public int Count;

        public Product() { }
        public Product(string name, double price, int count) 
        {
            Name = name;
            Price = price;
            Count = count;
        }

        public void Detail()
        {
            Console.WriteLine($"Product name: {Name}\nProduct price: {Price}\nProduct count: {Count}");
        }

        public double Discount(double discountPercent)
        {
            double discountedPrice = Price - ((Price * discountPercent) / 100);
            return discountedPrice;
        }

    }
}
