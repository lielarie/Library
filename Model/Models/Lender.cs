using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class Lender : User
    {
        public Lender() { }

        public Lender(string username, List<AbstractItem> rentedItems) : base(username, rentedItems) { }

        public Lender(int id ,string username, List<AbstractItem> rentedItems) : base(id, username, rentedItems) { }
    }
}
