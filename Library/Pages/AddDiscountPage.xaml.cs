using BL;
using DAL;
using Models.Enums;
using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Library.Pages
{
    public partial class AddDiscountPage : Page
    {
        Repository rep = new Repository();
        Logic logic = new Logic();

        public AddDiscountPage()
        {
            InitializeComponent();
            AddItemsToCombox();
        }

        public void AddItemsToCombox()
        {
            foreach (Genres genre in (Genres[])Enum.GetValues(typeof(Genres)))
            {
                genreCombo.Items.Add(genre);
            }
            foreach (Book book in rep.LoadBooks())
                pubCombo.Items.Add(book.Company);
        }

        private void confirmDiscount_Click(object sender, RoutedEventArgs e)
        {
            if (newPriceText.Text != "")
            {
                double newP = Convert.ToDouble(newPriceText.Text);
                newP /= 100;
                foreach (AbstractItem item in rep.LoadAllItems())
                {
                    if (genreCombo.SelectedItem != null && (Genres)genreCombo.SelectedItem == item.Genre)
                        logic.itemLogic.AddDiscount(item, newP);

                    else if (byPrintDate.SelectedDate != null &&  item.PrintDate.Equals(byPrintDate.SelectedDate.Value.Date.ToString("yyyy-MM-dd")))
                        logic.itemLogic.AddDiscount(item, newP);

                    else if (pubCombo.SelectedItem != null && item.Company == pubCombo.SelectedItem.ToString())
                        logic.itemLogic.AddDiscount(item, newP);
                }
                rep.SaveChangesAsync();
                MessageBox.Show($"The discount has been added!");
                ResetFields();
            }

            else
                MessageBox.Show($"Please enter a discount");
        }

        private void newPriceText_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        public void ResetFields()
        {
            genreCombo.SelectedItem = null;
            byPrintDate.SelectedDate = null;
            pubCombo.SelectedItem = null;
            newPriceText.Text = "";
        }
    }
}
