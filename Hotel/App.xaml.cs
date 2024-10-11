using Hotel.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Hotel
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        static Kozlov_Vlad_HotelEntities context = new Kozlov_Vlad_HotelEntities();
        public static Kozlov_Vlad_HotelEntities GetContext()
        {
            if(context != null)
            {
                return context;
            }
            else
            {
                context = new Kozlov_Vlad_HotelEntities();
                return context;
            }
        }
    }
}
