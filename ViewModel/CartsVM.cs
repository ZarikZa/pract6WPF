using pract6Kalendar.ViewModel.Helperi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;
using pract6Kalendar.Model;
using System.Windows.Media.Imaging;
using static System.Net.Mime.MediaTypeNames;

namespace pract6Kalendar.ViewModel
{
    internal class CartsVM : BindingHelp
    {
        public BindingClick Clear {  get; set; }

        public CartsVM(DateTime data1)
        {
            Clear = new BindingClick(_ => ClearClick(data1));
        }

        public void ClearClick(DateTime date)
        {
            Converter converter = new Converter();
            var list = converter.Jsonviser<List<ViborNaDayModel>>("MyMood.json");
            for (int i = 0; i < list.Count; i++)
            {
                if (date.Day == list[i].data.Day)
                {
                    list.Remove(list[i]);
                }
            }
            converter.Jsonser(list, "MyMood.json");
            MainWindow window = System.Windows.Application.Current.MainWindow as MainWindow;
            window.frame.Content = new main_menu(date);
        }
    }
}
