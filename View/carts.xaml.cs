using pract6Kalendar.Model;
using pract6Kalendar.ViewModel;
using pract6Kalendar.ViewModel.Helperi;
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
using static MaterialDesignThemes.Wpf.Theme.ToolBar;

namespace pract6Kalendar
{
    /// <summary>
    /// Логика взаимодействия для carts.xaml
    /// </summary>
    public partial class carts : UserControl
    {
        DateTime date1 = DateTime.Now;
        public carts(DateTime date)
        {
            InitializeComponent();
            date1 = date;
            DataContext = new CartsVM(date1);
        }
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            open_check();
        }
        private void See_Click(object sender, RoutedEventArgs e)
        {
            open_check();
        }
        private void open_check()
        {
            // открыть страницу выбора (вот чекни полная пизда и я эту зуйню главное понимаю) 
            MainWindow window = Window.GetWindow(this) as MainWindow;
            window.vm.DataKakayato =  date1.ToString("dd MMMM yyyy г.");
            Frame frame = window.frame;
            Menu_change menu_Change = new Menu_change();
            frame.Content = menu_Change;
            // анимация
        }
    }
}
