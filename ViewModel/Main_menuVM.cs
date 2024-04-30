using pract6Kalendar.Model;
using pract6Kalendar.ViewModel.Helperi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace pract6Kalendar.ViewModel
{
    internal class Main_menuVM : BindingHelp
    {
        private List<carts> colvoCarts = new List<carts>();

        public List<carts> ColvoCarts
        {
            get { return colvoCarts; }
            set { colvoCarts = value; OnPropertyChanged(); }
        }

        private string chislo;

        public string Chislo
        {
            get { return chislo; }
            set { chislo = value; OnPropertyChanged(); }
        }

        public Main_menuVM(DateTime date)
        {
            Kakashka_Parashka(date);
        }

        public void Kakashka_Parashka(DateTime date)
        {
            Converter converter = new Converter();
            var ViborsList = converter.Jsonviser<List<ViborNaDayModel>>("MyMood.json") ?? new List<ViborNaDayModel>();
            ColvoCarts.Clear();
            for (int i = 1; i <= DateTime.DaysInMonth(date.Year, date.Month); i++)
            {
                DateTime dat = new DateTime(date.Year, date.Month, i);
                carts carts = new carts(dat);
                foreach (var item in ViborsList)
                {
                    if (item.data == dat)
                    {
                        foreach (var item1 in item.viborModels)
                        {
                            if (item1.selected == true)
                            {
                                carts.KartinkaImg.Source = new BitmapImage(new Uri(item1.pathKartinki, UriKind.Relative));
                                break;
                            }
                        }
                    }
                }
                carts.date.Text = i.ToString();
                ColvoCarts.Add(carts);
            }
        }
    }
}
