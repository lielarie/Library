using Microsoft.EntityFrameworkCore;
using Models.Enums;
using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DAL
{
    public class ItemsContext : DbContext
    {
        const string connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=LibraryProject;Trusted_Connection=true";

        public virtual DbSet<AbstractItem> Items { get; set; }
        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<Journal> Journals { get; set; }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Librarian> Librarians { get; set; }
        public virtual DbSet<Lender> Lenders { get; set; }

        public ItemsContext() { }

        public ItemsContext(DbContextOptions<ItemsContext> options) : base(options)
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilider)
        {
            optionsBuilider.UseSqlServer(connectionString).UseLazyLoadingProxies().EnableSensitiveDataLogging();
            base.OnConfiguring(optionsBuilider);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().HasData(
                new Book
                {
                    Id = 1,
                    Name = "The Hunger Games",
                    PrintDate = new DateTime(1964, 11, 23),
                    Company = "Lion's Gate",
                    Price = 20,
                    Genre = Genres.Adventure,
                    Author = "Suzanne Collins",
                    IsAvailable = true
                },
                new Book
                {

                    Id = 2,
                    Name = "Harry Potter",
                    PrintDate = new DateTime(2007, 07, 21),
                    Company = "Bloomsbury Publishing",
                    Price = 25,
                    Genre = Genres.Adventure,
                    Author = "J.K. Rowling",
                    IsAvailable = true
                },
                new Book
                {

                    Id = 3,
                    Name = "Twilight",
                    PrintDate = new DateTime(2005, 10, 05),
                    Company = "Little, Brown and Company",
                    Price = 15,
                    Genre = Genres.Romance,
                    Author = "Stephenie Meyer",
                    IsAvailable = true
                },
                new Book
                {

                    Id = 4,
                    Name = "The Chronicles Of Narnia",
                    PrintDate = new DateTime(1956, 09, 04),
                    Company = "Geoffrey Bles",
                    Price = 35,
                    Genre = Genres.Fantasy,
                    Author = "C.S. Lewis",
                    IsAvailable = true
                },
                new Book
                {

                    Id = 5,
                    Name = "The Da Vinci Code",
                    PrintDate = new DateTime(2006, 05, 19),
                    Company = "Doubleday",
                    Price = 40,
                    Genre = Genres.Mystery,
                    Author = "Dan Brown",
                    IsAvailable = true
                },
                new Book
                {

                    Id = 6,
                    Name = "The Game Of Thrones",
                    PrintDate = new DateTime(1996, 08, 01),
                    Company = "Bantam Spectra",
                    Price = 55,
                    Genre = Genres.Fantasy,
                    Author = "George R.R.Martin",
                    IsAvailable = true
                },
                new Book
                {

                    Id = 7,
                    Name = "Charlie And The Chocolate Factory",
                    PrintDate = new DateTime(1964, 11, 23),
                    Company = "Alfred A. Knopf",
                    Price = 70,
                    Genre = Genres.Adventure,
                    Author = "Roald Dahl",
                    IsAvailable = true
                },
                new Book
                {

                    Id = 8,
                    Name = "Dracula",
                    PrintDate = new DateTime(1897, 05, 26),
                    Company = "Archibald Constable and Company",
                    Price = 100,
                    Genre = Genres.Horror,
                    Author = "Bram Stoker",
                    IsAvailable = true
                },
                new Book
                {
                    Id = 9,
                    Name = "Bossypants",
                    PrintDate = new DateTime(2011, 04, 05),
                    Company = "Little, Brown and Company",
                    Price = 75,
                    Genre = Genres.Comedy,
                    Author = "Tina Fey",
                    IsAvailable = true
                });

            modelBuilder.Entity<Journal>().HasData(
                new Journal
                {

                    Id = 10,
                    Name = "Yedioth Aharonot",
                    PrintDate = new DateTime(1939, 12, 11),
                    Company = "Yedioth Aharonot LTD",
                    Price = 5,
                    Genre = Genres.News,
                    IsAvailable = true
                });

            modelBuilder.Entity<Lender>().HasData(
                new Lender
                {
                    Id = 1,
                    Username = "dan",
                });

            modelBuilder.Entity<Librarian>().HasData(
                new Librarian
                {
                    Id = 2,
                    Username = "liel",
                    Password = "1234"
                }
                );

            base.OnModelCreating(modelBuilder);
        }
    }
}
