using QuizUserManagement;

using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace QuizApp
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        private UserRepository userRepository = new UserRepository();
        public Login()
        {
            InitializeComponent();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var user = userRepository.Login(tbxUsername.Text, tbxPassword.Password);
            if (user == null)
            {
                MessageBox.Show("Bad user");
            }
            else
            {
                MessageBox.Show($"Hello {user.FullName}");
            }
        }
    }
}
