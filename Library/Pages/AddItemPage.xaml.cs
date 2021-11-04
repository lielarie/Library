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
    public partial class AddItemPage : Page
    {
        AbstractItem item;
        Logic logic = new Logic();
        bool isBook = false;
        Repository rep = new Repository();

        public AddItemPage()
        {
            InitializeComponent();
            AddGenresToCombo();
        }

        private void journalAdd_Click(object sender, RoutedEventArgs e)
        {
            JournalClick();
        }

        public void AddGenresToCombo()
        {
            foreach (Genres genre in (Genres[])Enum.GetValues(typeof(Genres)))
                comboG.Items.Add(genre);
        }

        public void JournalClick()
        {
            isBook = false;
            nameText.Visibility = Visibility.Visible;
            pubText.Visibility = Visibility.Visible;
            comboG.Visibility = Visibility.Visible;
            dateText.Visibility = Visibility.Visible;
            priceText.Visibility = Visibility.Visible;
            name.Visibility = Visibility.Visible;
            publisher.Visibility = Visibility.Visible;
            genre.Visibility = Visibility.Visible;
            printDate.Visibility = Visibility.Visible;
            price.Visibility = Visibility.Visible;
            authorText.Visibility = Visibility.Collapsed;
            author.Visibility = Visibility.Collapsed;
            addItemButton.Visibility = Visibility.Visible;
            addItemButton.Content = "Add Journal";
        }

        public void BookClick()
        {
            isBook = true;
            nameText.Visibility = Visibility.Visible;
            pubText.Visibility = Visibility.Visible;
            comboG.Visibility = Visibility.Visible;
            dateText.Visibility = Visibility.Visible;
            priceText.Visibility = Visibility.Visible;
            name.Visibility = Visibility.Visible;
            publisher.Visibility = Visibility.Visible;
            genre.Visibility = Visibility.Visible;
            printDate.Visibility = Visibility.Visible;
            price.Visibility = Visibility.Visible;
            authorText.Visibility = Visibility.Visible;
            author.Visibility = Visibility.Visible;
            addItemButton.Visibility = Visibility.Visible;
            addItemButton.Content = "Add Book";
        }

        private void bookAdd_Click(object sender, RoutedEventArgs e)
        {
            BookClick();
        }

        private void addItemButton_Click(object sender, RoutedEventArgs e)
        {
            if (nameText.Text != null || pubText.Text != null || comboG.SelectedItem != null ||
                dateText.SelectedDate != null || priceText.Text != null)
            {
                if (logic.itemLogic.CheckIfItemExists(nameText.Text))
                {
                    if (isBook)
                    {
                        item = new Book(nameText.Text, 
                            dateText.SelectedDate.Value, pubText.Text, 
                            Convert.ToDouble(priceText.Text), (Genres)Enum.Parse(typeof(Genres), comboG.SelectedItem.ToString()),
                            authorText.Text);
                    }
                    else
                    {
                        item = new Journal(nameText.Text,
                            dateText.SelectedDate.Value, pubText.Text,
                            Convert.ToDouble(priceText.Text), (Genres)Enum.Parse(typeof(Genres), comboG.SelectedItem.ToString()));
                    }
                    rep.SaveItemAsync(item);
                    MessageBox.Show(item.GetType() + " Added successfully!");
                }
                else
                {
                    MessageBox.Show("This " + item.GetType().ToString() + " already exists in our library");
                }
                CleanInfo();
            }
            else MessageBox.Show("Some information is missing");
        }

        public void CleanInfo()
        {
            nameText.Text = "";
            dateText.SelectedDate = null;
            pubText.Text = "";
            authorText.Text = "";
            comboG.SelectedItem = null;
            priceText.Text = "";
        }

        private void priceText_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
    }
}
