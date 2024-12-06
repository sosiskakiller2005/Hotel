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
    /// Логика взаимодействия для NewUserWindow.xaml
    /// </summary>
    public partial class NewUserWindow : Window
    {
        private static Kozlov_Vlad_HotelEntities _context = App.GetContext();
        public NewUserWindow()
        {
            InitializeComponent();
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            if (LoginTB.Text != string.Empty && FullnameTb.Text != string.Empty && PasswordTb.Password != string.Empty)
            {
                User newUser = new User()
                {
                    Fullname = FullnameTb.Text,
                    Login = LoginTB.Text,
                    Password = PasswordTb.Password,
                    RegistrationDate = DateTime.Now,
                    IsActivated = false,
                    IsBlocked = false,
                    RoleId = 2
                };
                _context.User.Add(newUser);
                MessageBoxHelper.Information("Пользователь добавлен.");
                DialogResult = true;
                Close();
            }
        }
    }
}
