using BL;
using DAL;
using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
    public partial class EditItemPage : Page
    {
        AbstractItem _item;
        Repository rep = new Repository();
        Logic logic = new Logic();

        public EditItemPage(AbstractItem item)
        {
            _item = item;
            InitializeComponent();
            nameText.Text = item.Name;
            dateText.SelectedDate = item.PrintDate;
            publisherText.Text = item.Company;
            priceText.Text = item.Price.ToString();
        }

        private void confirmButton_Click(object sender, RoutedEventArgs e)
        {
            if (nameText.Text != null && dateText.SelectedDate != null && 
                publisherText.Text != null && priceText.Text != null)
            {
                _item.Name = nameText.Text;
                _item.PrintDate = dateText.SelectedDate.Value;
                _item.Name = nameText.Text;
                _item.Name = nameText.Text;
                _item.Name = nameText.Text;
                MessageBox.Show("The changes have been made");
                rep.SaveChangesAsync();
            }
        }
    }
}
