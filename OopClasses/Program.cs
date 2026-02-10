namespace OopClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product book = new Product("Dune Messiah", 1000, 45987);

            book.Detail();
            Console.WriteLine(book.Discount(10.10));

        }
    }
}
