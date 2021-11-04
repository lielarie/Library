using DAL;
using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class InformationLogic
    {
        Repository rep = new Repository();

        public bool CheckPasswords(string password, string rePassword)
        {
            if (password == rePassword) return true;
            return false;
        }

        public List<AbstractItem> RefreshListView(string searched) //Refreshes the books listview.
        {
            List<AbstractItem> matchedItems = new List<AbstractItem>();

            foreach (AbstractItem item in rep.LoadAllItems())
                if (item.Name.Contains(searched) || item.Company.Contains(searched)
                    || item.Genre.ToString().Contains(searched)) matchedItems.Add(item);
            return matchedItems;
        }
    }
}
