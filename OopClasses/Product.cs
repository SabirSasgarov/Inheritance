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
        public Book[] Books;

        public Product(string name, double price) 
        {
            Name = name;
            Price = price;
            Books = new Book[0];
        }

        public void AddBook(Book book)
        {
            Array.Resize(ref Books,Books.Length+1);
            Books[Books.Length - 1]=book;
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

		public void ShowBooks(string genre)
		{
			Console.WriteLine("Books: ");
			foreach (var book in Books)
				Console.WriteLine($"Book name: {Name}, Book genre:{genre},Book price: {Price}, Count: {Count}");
		}


	}
}
