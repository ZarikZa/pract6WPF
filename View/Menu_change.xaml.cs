using pract6Kalendar.ViewModel;
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
    /// Логика взаимодействия для Menu_change.xaml
    /// </summary>
    public partial class Menu_change : Page
    {
        public Menu_change()
        {
            InitializeComponent();
            DataContext = new Menu_changeVM();
        }

        private void SaveBtm_Click(object sender, RoutedEventArgs e)
        {
            DoubleAnimation anim = new DoubleAnimation();
            anim.From = SaveBtm.ActualHeight;
            anim.To = 50;
            anim.Duration = TimeSpan.FromSeconds(1);
            anim.FillBehavior = FillBehavior.Stop;
            SaveBtm.BeginAnimation(Button.HeightProperty, anim);
        }
    }
}
