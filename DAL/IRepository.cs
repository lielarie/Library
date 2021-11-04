using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IRepository
    {
        List<AbstractItem> LoadAllItems();
        List<Book> LoadBooks();
        List<Journal> LoadJournals();
        List<Lender> LoadLenders();
        List<Librarian> LoadLibrarians();
        Library LoadLibrary();

        void SaveItemAsync(AbstractItem item);
        void SaveUserAsync(User user);
    }
}
