using Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class Book : AbstractItem
    {
        public string Author { get; set; }

        public Book(string name, DateTime printDate, string companyName, double price, Genres genre, string author, bool isAvailable = true)
            : base(name, printDate, companyName, price, genre, isAvailable)
        {
            Author = author;
        }
        public Book(int id ,string name, DateTime printDate, string companyName, double price, Genres genre, string author, bool isAvailable = true)
            : base(id, name, printDate, companyName, price, genre, isAvailable)
        {
            Author = author;
        }

        public Book() { }
    }
}
