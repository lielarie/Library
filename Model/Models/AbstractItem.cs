using Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public abstract class AbstractItem
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        public DateTime PrintDate { get; set; }
        public string Company { get; set; }
        public double Price { get; set; }
        public Genres Genre { get; set; }
        public bool IsAvailable { get; set; }

        public AbstractItem() { }

        protected AbstractItem(string name, DateTime printDate, string companyName, double price, Genres genre, bool isAvailable = true)
        {
            Name = name;
            PrintDate = printDate;
            Company = companyName;
            Price = price;
            Genre = genre;
            IsAvailable = isAvailable;
        }
        protected AbstractItem(int id ,string name, DateTime printDate, string companyName, double price, Genres genre, bool isAvailable = true)
        {
            Id = id;
            Name = name;
            PrintDate = printDate;
            Company = companyName;
            Price = price;
            Genre = genre;
            IsAvailable = isAvailable;
        }
    }
}
