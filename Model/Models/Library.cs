using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class Library
    {
        public static List<User> Users { get; set; }
        public static List<Lender> Lenders { get; set; }
        public static List<Librarian> Librarians { get; set; }

        public static List<AbstractItem> Items { get; set; }
        public static List<Book> Books { get; set; }
        public static List<Journal> Journals { get; set; }
        public static List<string> Publishers { get; set; }

        public Library()
        {
            Lenders = new List<Lender>();
            Librarians = new List<Librarian>();
            Books = new List<Book>();
            Journals = new List<Journal>();
            Publishers = new List<string>();
        }

        public void SetItems(List<Book> books, List<Journal> journals,
            List<Lender> lenders, List<Librarian> librarians)
        {
            foreach (var book in books)
                Books.Add(book);

            foreach (var journal in journals)
                Journals.Add(journal);

            foreach (var lender in lenders)
                Lenders.Add(lender);

            foreach (var librarian in librarians)
                Librarians.Add(librarian);
        }

        public void AddPublishers()
        {
            foreach (AbstractItem item in Items)
                Publishers.Add(item.Company);
        }
    }
}
