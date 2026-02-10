using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopClasses
{
    internal class Book : Product
    {
        public string Genre;

        public Book(string name, double price,string genre)
        {
            Name = name;
            Price = price;
            Genre = genre;
        }



    }
}
