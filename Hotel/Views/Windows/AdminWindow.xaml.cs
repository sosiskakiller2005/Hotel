﻿using Hotel.AppData;
using Hotel.Model;
using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace Hotel.Views.Windows
{
    /// <summary>
    /// Логика взаимодействия для AdminWindow.xaml
    /// </summary>
    public partial class AdminWindow : Window
    {
        private static User _selectedUser = AuthorisationHelper.selectedUser;
        private static Kozlov_Vlad_HotelEntities _context = App.GetContext();
        public AdminWindow()
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

        private void NewUserBtn_Click(object sender, RoutedEventArgs e)
        {
            NewUserWindow newUserWindow = new NewUserWindow();
            if (newUserWindow.ShowDialog() == true)
            {
                UsersLv.ItemsSource = _context.User.ToList();
            }
        }
    }
}
