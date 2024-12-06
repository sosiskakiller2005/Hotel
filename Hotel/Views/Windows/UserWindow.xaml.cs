using Hotel.Views.Pages;
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
    /// Логика взаимодействия для UserWindow.xaml
    /// </summary>
    public partial class UserWindow : Window
    {
        public UserWindow()
        {
            InitializeComponent();
        }

        private void UsersBtn_Click(object sender, RoutedEventArgs e)
        {
            MainFrm.Navigate(new UserPage());
        }

        private void RoomsBtn_Click(object sender, RoutedEventArgs e)
        {
            MainFrm.Navigate(new RoomsPage());
        }
    }
}
