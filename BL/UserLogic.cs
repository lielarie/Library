using DAL;
using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class UserLogic
    {
        Repository rep = new Repository();
        InformationLogic infoLogic = new InformationLogic();
        User user;

        public Librarian CheckLibrarian(string username, string password)
        {
            try
            {
                Librarian lib = rep.LoadLibrarians().FirstOrDefault(user => (username == user.Username) && (password == user.Password));
                return lib;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public Lender CheckLender(string username)
        {
            try
            {
                user = rep.LoadLenders().First(user => username == user.Username);
                return (Lender)user;
            }
            catch
            {
                user = new Lender { Username = username, RentedItems = new List<AbstractItem>() };
                rep.SaveUserAsync(user);
                return (Lender)user;
            }
        }

        public bool CheckNewUser(string firstname, string lastname, string username, string password)
        {
            if (firstname.Length < 2 || lastname.Length < 2 || username.Length < 3
                || password.Length < 4) return false;
            return true;
        }

        public bool AddUser(string username, string password, string rePassword)
        {
            if (password != rePassword) return false;

            if (username.Length > 3 && password.Length > 3)
            {
                if (rep.LoadLibrarians().FirstOrDefault(p => p.Username == username) != null) return false;
                Librarian lib = new Librarian { Username = username, Password = password };
                rep.SaveUserAsync(lib);
                return true;
            }
            return false;
        }
    }
}
