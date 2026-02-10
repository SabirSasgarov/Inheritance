namespace OopClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product jurnal = new Product("Dune Messiah",10000);
            jurnal.Detail();
            Console.WriteLine(jurnal.Discount(10.10));

        }
    }
}
