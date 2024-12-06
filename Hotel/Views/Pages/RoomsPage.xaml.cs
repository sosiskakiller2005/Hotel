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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Hotel.Views.Pages
{
    /// <summary>
    /// Логика взаимодействия для RoomsPage.xaml
    /// </summary>
    public partial class RoomsPage : Page
    {
        private static Kozlov_Vlad_HotelEntities _context = App.GetContext();
        public RoomsPage()
        {
            InitializeComponent();
            RoomsLb.ItemsSource = _context.Room.ToList();
        }

        private void SearchTb_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void FilterByCategoryCmb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void RoomsLb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void NewUserBtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
