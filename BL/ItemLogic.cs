using DAL;
using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class ItemLogic
    {
        Repository rep = new Repository();

        public bool CheckIfItemExists(string item)
        {
            foreach (AbstractItem product in rep.LoadAllItems())
                if (product.Name == item) return false;
            return true;
        }

        public void AddDiscount(AbstractItem item, double percent)
        {
            item.Price = item.Price * (1 - percent);
            rep.SaveChangesAsync();
        }
    }
}
