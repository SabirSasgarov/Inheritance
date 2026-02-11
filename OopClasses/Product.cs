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
        public Book[] Books=new Book[0];

        public Product(string name, double price) 
        {
            Name = name;
            Price = price;
        }

        public void AddBook(Book book)
        {
            Array.Resize(ref Books,Books.Length+1);
			Console.WriteLine(book);
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

		public void ShowBooks()
		{
			Console.WriteLine("Books: ");
			foreach (var book in Books)
				Console.WriteLine($"Book name: {book.Name}       |      Book genre: {book.Genre}       |       Book price: {book.Price}        |       Count:{book.Count}");
		}


	}
}
