using pract6Kalendar.ViewModel.Helperi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace pract6Kalendar.ViewModel
{
    internal class MainWindowVM : BindingHelp
    {
        DateTime date = DateTime.Now;

        public BindingClick Next {  get; set; }
        public BindingClick Back {  get; set; }

        private string dataKakayato;

        public string DataKakayato
        {
            get { return dataKakayato; }
            set { dataKakayato = value; OnPropertyChanged();  }
        }

        private object contentXZ;

        public object ContentXZ
        {
            get { return contentXZ; }
            set { contentXZ = value; OnPropertyChanged(); }
        }

        public MainWindowVM()
        {
            Next = new BindingClick(_ => NextClick());
            Back = new BindingClick(_ => BackClick());
            Refresh();
        }

        public void Refresh()
        {
            DataKakayato = date.ToString("Y");
            main_menu main_menu = new main_menu(date);
            ContentXZ = main_menu;
        }

        public void BackClick()
        {
            date = date.AddMonths(1);
            Refresh();
        }

        public void NextClick()
        {
            date = date.AddMonths(-1);
            Refresh();
        }

    }
}
