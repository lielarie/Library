using BL;
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
    public partial class AddUser : Window
    {
        Logic logic = new Logic();

        public AddUser()
        {
            InitializeComponent();
        }

        private void newUserConfirm_Click(object sender, RoutedEventArgs e)
        {
            if (logic.userLogic.AddUser(usernameT.Text, passwordT.Password, repPasswordT.Password))
            {
                this.Close();
                MessageBox.Show($"User {usernameT.Text} added successfully!");
            }
            else
            {
                MessageBox.Show("Criterions: " +
                "\nUsername should have at least 3 chars." +
                "\nPassword should have at least 3 chars." +
                "\nPasswords should match.");
            }
        }
    }
}
