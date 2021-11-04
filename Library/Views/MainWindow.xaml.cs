using BL;
using DAL;
using Library.Views;
using Models.Models;
using System.Windows;

namespace Library
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        AddUser nu = new AddUser();
        Logic logic = new Logic();
        Repository rep = new Repository();
        ItemsContext db;
        public User CurrentUser { get; set; }
        Information information;

        public MainWindow() { }

        public MainWindow(ItemsContext itemsContext)
        {
            db = itemsContext;
            InitializeComponent();
        }

        private void librarian_Click(object sender, RoutedEventArgs e)
        {
            CurrentUser = logic.userLogic.CheckLibrarian(usernameText.Text, passwordText.Password);
            if (CurrentUser == null) MessageBox.Show("Wrong information");
            else
            {
                information = new Information(CurrentUser);
                this.Close();
                information.ShowDialog();
            }
        }

        private void lender_Click(object sender, RoutedEventArgs e)
        {
            Lender lender = logic.userLogic.CheckLender(lenderName.Text);
            CurrentUser = lender;
            information = new Information(CurrentUser);
            this.Close();
            information.ShowDialog();
        }


        private void NewUserButton_Click(object sender, RoutedEventArgs e)
        {
            nu.ShowDialog();
        }
    }
}