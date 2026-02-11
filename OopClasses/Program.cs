using System.Threading.Channels;

namespace OopClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region task1-part1
            //Book book1 = new Book("BookName1", 10.50, "Sci-FI");
            //book1.Detail();
            //Console.WriteLine(book1.Discount(50));
            #endregion

            #region Task1-part2
            Product product = new Product("Books", 500);
            Console.WriteLine("Kitab sayini daxil edin.");
            int inputCount = int.Parse(Console.ReadLine());
            string genre=string.Empty;
            int count = default;
			while (count<inputCount)
            {
				Console.WriteLine("Sirasi ile kitabin adini, qiymeditini ve janrini qeyd edin: ");
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine());
                genre = Console.ReadLine();
                product.AddBook(new(name, price, genre)
                {
                    Name = name,
                    Price = price,
                    Genre = genre
                });
                count++;
            }

			Console.WriteLine("1.Kitablari qiymete gore filterle\n2.Butun kitablari goster \n0. Proqrami bagla");
            int operation = int.Parse(Console.ReadLine());
            switch (operation) {
                case 1:
                    
                    break;
                case 2:
					product.ShowBooks();
                    break;
                default:
					Console.WriteLine("Proqram baglandi!");
                    break;
            }



			#endregion



			#region Task2
			//Shape random = new Shape("red");
			//random.GetInfo();

			//Circle circle1 = new Circle("green", 5);
			//circle1.GetInfo();

			//Rectangle rectangle1 = new Rectangle("yellow", 8);
			//rectangle1.GetInfo();
			#endregion

		}
	}
}
