using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public abstract class User
    {
        [Key]
        public int Id { get; set; }
        public string Username { get; set; }
        public virtual List<AbstractItem> RentedItems { get; set; }

        public User(int id , string username, List<AbstractItem> rentedItems)
        {
            Id = id;
            Username = username;
            RentedItems = rentedItems;
        }

        public User() { }

        public User(string username, List<AbstractItem> rentedItems)
        {
            Username = username;
            RentedItems = rentedItems;
        }
    }
}
