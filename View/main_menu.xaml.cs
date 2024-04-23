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

namespace pract6Kalendar
{
    /// <summary>
    /// Логика взаимодействия для main_menu.xaml
    /// </summary>
    public partial class main_menu : Page
    {
        public main_menu(DateTime date)
        {
            InitializeComponent();
            //обновление карточек после нажатия кнопок
            wrapPanel.Children.Clear();
            for (int i = 1; i < DateTime.DaysInMonth(date.Year, date.Month); i++)
            {
                carts carts = new carts();
                carts.date.Text = i.ToString();

                wrapPanel.Children.Add(carts);
            }
        }
    }
}
