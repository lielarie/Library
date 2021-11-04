using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class Librarian : User
    {
        public string Password { get; set; }

        public Librarian() { }

        public Librarian(string username, string password, List<AbstractItem> rentedItems) : base (username, rentedItems)
        {
            Password = password;
        } 
        public Librarian(int id, string username, string password, List<AbstractItem> rentedItems) : base (id, username, rentedItems)
        {
            Password = password;
        }
    }
}
