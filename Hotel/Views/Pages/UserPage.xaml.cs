using Hotel.AppData;
using Hotel.Model;
using Hotel.Views.Windows;
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

namespace Hotel.Views.Pages
{
    /// <summary>
    /// Логика взаимодействия для UserPage.xaml
    /// </summary>
    public partial class UserPage : Page
    {
        private static User _selectedUser = AuthorisationHelper.selectedUser;
        private static Kozlov_Vlad_HotelEntities _context = App.GetContext();
        public UserPage()
        {
            InitializeComponent();
            UsersLv.ItemsSource = _context.User.ToList();
            RoleCmb.ItemsSource = _context.Role.ToList();
            RoleCmb.DisplayMemberPath = "Name";
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UserGrid.DataContext = UsersLv.SelectedItem as User;
        }

        private void NewUserBtn_Click(object sender, RoutedEventArgs e)
        {
            NewUserWindow newUserWindow = new NewUserWindow();
            if (newUserWindow.ShowDialog() == true)
            {
                UsersLv.ItemsSource = _context.User.ToList();
            }
        }

        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            _selectedUser.Fullname = FullnameTb.Text;
            _selectedUser.RegistrationDate = (DateTime)RegistrationDp.SelectedDate;
            _selectedUser.Login = LoginTb.Text;
            _selectedUser.IsActivated = (bool)IsActivatedCb.IsChecked;
            _selectedUser.IsBlocked = (bool)IsBlocked.IsChecked;
            _context.SaveChanges();
            MessageBox.Show("Информация изменена.");
        }
    }
}
