using Hotel.AppData;
using Hotel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
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
    /// Логика взаимодействия для ChangePasswordWindow.xaml
    /// </summary>
    public partial class ChangePasswordWindow : Window
    {
        private static Kozlov_Vlad_HotelEntities _context = App.GetContext();
        public static User _selectedUser;
        public ChangePasswordWindow()
        {
            InitializeComponent();
            _selectedUser = AuthorisationHelper.selectedUser;
        }

        private void ChangePasswordBtn_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(AcceptNewPasswordPb.Password) || string.IsNullOrEmpty(NewPasswordPb.Password))
            {
                MessageBoxHelper.Error("Заполните все поля для ввода.");
            }
            else
            {
                if (AcceptNewPasswordPb.Password != NewPasswordPb.Password)
                {
                    MessageBoxHelper.Error("Пароли не совпадают.");
                }
                else
                {
                    _selectedUser.Password = AcceptNewPasswordPb.Password;
                    _context.SaveChanges();
                }
            }
        }
    }
}
