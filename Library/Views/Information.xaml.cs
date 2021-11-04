using DAL;
using Library.Pages;
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
using System.Windows.Shapes;

namespace Library.Views
{
    /// <summary>
    /// Interaction logic for Information.xaml
    /// </summary>
    public partial class Information : Window
    {
        public List<string> Publishers { get; set; }
        public User User { get; set; }
        AddItemPage aip;
        SearchItemPage sip;
        AddDiscountPage adp;
        Repository rep = new Repository();

        public Information(User user)
        {
            InitializeComponent();
            Publishers = new List<string>();
            if (user is Librarian)
                User = (Librarian)user;
            if (user is Lender)
                User = (Lender)user;
            welcomeName.Text = "Welcome " + user.Username;
        }

        private void addItemB_Click(object sender, RoutedEventArgs e)
        {
            if (User is Librarian)
            {
                aip = new AddItemPage();
                Frame.Content = aip;
            }
            else MessageBox.Show("Only librarians are allowed!");
        }

        private void searchItemB_Click(object sender, RoutedEventArgs e)
        {
            sip = new SearchItemPage(User);
            Frame.Content = sip;
        }

        private void discountItem_Click(object sender, RoutedEventArgs e)
        {
            if (User is Librarian)
            {
                adp = new AddDiscountPage();
                Frame.Content = adp;
            }
            else MessageBox.Show("Only librarians are allowed!");
        }

        private void dailyRep_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Daily Report:" +
                "\nTotal Books: " + rep.LoadBooks().Count() +
                "\nTotal Journals: " + rep.LoadJournals().Count() + 
                "\n Total Rented Items: " + rep.LoadRentedItems().Count());
        }
    }
}
