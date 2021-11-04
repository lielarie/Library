using Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class Journal : AbstractItem
    {
        public Journal(string name, DateTime printDate, string companyName, double price, Genres genre, bool isAvailable = true)
            : base(name, printDate, companyName, price, genre, isAvailable) { }
        
        public Journal(int id,string name, DateTime printDate, string companyName, double price, Genres genre, bool isAvailable = true)
            : base(id,name, printDate, companyName, price, genre, isAvailable) { }

        public Journal() { }
    }
}
