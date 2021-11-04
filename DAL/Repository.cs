using Models.Models;
using System.Collections.Generic;
using System.Linq;

namespace DAL
{
    public class Repository : IRepository
    {
        private readonly ItemsContext db = new ItemsContext();
        public List<AbstractItem> LoadAllItems() => db.Items.ToList();
        public List<Book> LoadBooks() => db.Books.ToList();
        public List<Journal> LoadJournals() => db.Journals.ToList();
        public List<Lender> LoadLenders() => db.Lenders.ToList();
        public List<Librarian> LoadLibrarians() => db.Librarians.ToList();
        public List<AbstractItem> LoadRentedItems() => db.Items.Where(item => item.IsAvailable == false).ToList();

        public Repository(ItemsContext database)
        {
            db = database;
        }

        public Repository() { }

        public void SaveChangesAsync()
        {
            db.SaveChangesAsync();
        }

        public async void RentItemAsync(AbstractItem item, User user)
        {
            item.IsAvailable = false;
            user.RentedItems.Add(item);
            await db.SaveChangesAsync();
        }

        public async void RemoveItemAsync(AbstractItem item)
        {
            db.Items.Remove(item);
            await db.SaveChangesAsync();
            //if (item != null)
            //{
            //    if (item is Book) db.Books.Remove((Book)item);
            //    else db.Journals.Remove((Journal)item);
            //    await db.SaveChangesAsync();
            //}
        }

        public async void SaveItemAsync(AbstractItem item)
        {
            if (item != null)
            {
                if (item is Book) db.Books.Add((Book)item);
                else db.Journals.Add((Journal)item);
                await db.SaveChangesAsync();
            }
        }

        public async void SaveUserAsync(User user)
        {
            if (user != null)
            {
                if (user is Lender)
                    db.Lenders.Add((Lender)user);
                if (user is Librarian)
                    db.Librarians.Add((Librarian)user);
            }
            await db.SaveChangesAsync();
        }

        public Library LoadLibrary()
        {
            Library library = new Library();
            try
            {
                library.SetItems(LoadBooks(), LoadJournals(), LoadLenders(), LoadLibrarians());
            }
            catch
            {
                db.Database.EnsureDeleted();
                db.Database.EnsureCreated();
                library.SetItems(LoadBooks(), LoadJournals(), LoadLenders(), LoadLibrarians());
            }
            return library;
        }
    }
}
