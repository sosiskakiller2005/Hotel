using Hotel.AppData;
using Hotel.Model;
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

namespace Hotel.Views.Windows
{
    /// <summary>
    /// Логика взаимодействия для AuthorisationWindow.xaml
    /// </summary>
    public partial class AuthorisationWindow : Window
    {
        public AuthorisationWindow()
        {
            InitializeComponent();
        }

        private void EntryBtn_Click(object sender, RoutedEventArgs e)
        {
            if (AuthorisationHelper.Authorise(LoginTb.Text, PasswordPb.Password))
            {
                switch (AuthorisationHelper.selectedUser.IsActivated)
                {
                    case true:
                        UserWindow userWindow = new UserWindow();
                        userWindow.Show();
                        Close();
                        break;
                    case false:
                        ChangePasswordWindow changePasswordWindow = new ChangePasswordWindow();
                        changePasswordWindow.Show();
                        Close();
                        break;
                }
            }
        }
    }
}
