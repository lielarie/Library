using BL;
using DAL;
using Library.Views;
using Models.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
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
    public partial class SearchItemPage : Page
    {
        Repository rep = new Repository();
        Logic logic = new Logic();
        MainWindow mw = new MainWindow();
        EditItemPage eip;
        public User User { get; set; }
        AbstractItem item;

        public SearchItemPage(User user)
        {
            InitializeComponent();
            bookList.ItemsSource = RefreshListView();
            if (user is Librarian)
                User = (Librarian)user;
            if (user is Lender)
                User = (Lender)user;
        }

        private void searchButton_Click(object sender, RoutedEventArgs e)
        {
            var t = new CultureInfo("en-US", false).TextInfo;
            searchText.Text = t.ToTitleCase(searchText.Text);
            bookList.ItemsSource = RefreshListView(searchText.Text);
        }

        public List<AbstractItem> RefreshListView(string searched = "") //Refreshes the books listview.
        {
            List<AbstractItem> matchedItems = new List<AbstractItem>();

            foreach (AbstractItem item in rep.LoadAllItems())
                if (item.Name.Contains(searched) || item.Company.Contains(searched)
                    || item.Genre.ToString().Contains(searched)) matchedItems.Add(item);
            return matchedItems;
        }

        private void removeItem_Click(object sender, RoutedEventArgs e)
        {
            if (User is Librarian)
            {
                item = (AbstractItem)bookList.SelectedItem;
                if (MessageBox.Show($"Are you sure you want to remove '{item.Name}'?", "Question", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
                {
                    rep.RemoveItemAsync(item);
                    Thread.Sleep(500);
                    bookList.ItemsSource = rep.LoadAllItems();
                }
            }
            else MessageBox.Show("Only librarians are allowed!");
        }

        private void editItem_Click(object sender, RoutedEventArgs e)
        {
            if (User is Librarian)
            {
                frameView.Visibility = Visibility.Visible;
                eip = new EditItemPage((AbstractItem)bookList.SelectedItem);
                frameView.Content = eip;
                RefreshListView();
            }
        }

        private void rentItem_Click(object sender, RoutedEventArgs e)
        {
            item = (AbstractItem)bookList.SelectedItem;
            if (MessageBox.Show($"Sure you want to rent {item.Name}?", "Question", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
            {
                rep.RentItemAsync(item, User);
                Thread.Sleep(500);
                bookList.ItemsSource = rep.LoadAllItems();
            }
        }
    }
}
