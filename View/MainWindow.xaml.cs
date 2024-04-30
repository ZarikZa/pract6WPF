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
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        internal MainWindowVM vm;
        public MainWindow()
        {
            InitializeComponent();

            vm = new MainWindowVM();
            DataContext = vm;
        }
   
        private void back_btn_Click(object sender, RoutedEventArgs e)
        {
            // анимации
            DoubleAnimationUsingKeyFrames size = new DoubleAnimationUsingKeyFrames();
            size.Duration = TimeSpan.FromSeconds(2);
            size.KeyFrames.Add(new LinearDoubleKeyFrame(650,KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.5))));
            size.KeyFrames.Add(new LinearDoubleKeyFrame(600, KeyTime.FromTimeSpan(TimeSpan.FromSeconds(1))));
            this.BeginAnimation(WidthProperty, size);
            ColorAnimation color = new ColorAnimation();
            back_btn.Background = ((SolidColorBrush)back_btn.Background).Clone();
            color.To = Colors.Pink;
            color.Duration = TimeSpan.FromSeconds(1.5);
            back_btn.Background.BeginAnimation(SolidColorBrush.ColorProperty, color);
        }

        private void next_btm_Click(object sender, RoutedEventArgs e)
        {
            //анимации
            DoubleAnimationUsingKeyFrames size = new DoubleAnimationUsingKeyFrames();
            size.Duration = TimeSpan.FromSeconds(1);
            size.KeyFrames.Add(new LinearDoubleKeyFrame(650, KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.5))));
            size.KeyFrames.Add(new LinearDoubleKeyFrame(600, KeyTime.FromTimeSpan(TimeSpan.FromSeconds(1))));
            this.BeginAnimation(WidthProperty, size);
            ColorAnimation color = new ColorAnimation();
            next_btm.Background = ((SolidColorBrush)next_btm.Background).Clone();
            color.To = Colors.Pink;
            color.Duration = TimeSpan.FromSeconds(1.5);
            next_btm.Background.BeginAnimation(SolidColorBrush.ColorProperty, color);
        }
    }
}
