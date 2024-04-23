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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace pract6Kalendar
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DateTime date = DateTime.Now;
        public MainWindow()
        {
            InitializeComponent();
            Refresh();
        }
        private void Refresh()
        {
            date_txtblc.Text = date.ToString("Y");
            main_menu main_menu = new main_menu(date);
            frame.Content = main_menu;
        }

        private void back_btn_Click(object sender, RoutedEventArgs e)
        {
            // анимации
            ColorAnimation color = new ColorAnimation();
            back_btn.Background = ((SolidColorBrush)back_btn.Background).Clone();
            color.To = Colors.Aqua;
            color.Duration = TimeSpan.FromSeconds(2);
            back_btn.Background.BeginAnimation(SolidColorBrush.ColorProperty, color);
            //изменение мксяца
            date = date.AddMonths(-1);
            Refresh();
        }

        private void next_btm_Click(object sender, RoutedEventArgs e)
        {
            //анимации
            ColorAnimation color = new ColorAnimation();
            next_btm.Background = ((SolidColorBrush)next_btm.Background).Clone();
            color.To = Colors.Aqua;
            color.Duration = TimeSpan.FromSeconds(2);
            next_btm.Background.BeginAnimation(SolidColorBrush.ColorProperty, color);
            // изменения месяца
            date = date.AddMonths(1);
            Refresh();
        }
    }
}
