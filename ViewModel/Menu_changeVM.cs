using pract6Kalendar.Model;
using pract6Kalendar.ViewModel.Helperi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media.Imaging;

namespace pract6Kalendar.ViewModel
{
    internal class Menu_changeVM : BindingHelp
    {
		public BindingClick Selected { get; set; }
		public BindingClick Save { get; set; }

		private BitmapImage pathKartinkiFastFood;

		public BitmapImage PathKartinkiFastFood
        {
			get { return pathKartinkiFastFood; }
			set { pathKartinkiFastFood = value; OnPropertyChanged(); }
		}

		private string fastFoodtxt;

		public string FastFoodtxt
		{
			get { return fastFoodtxt; }
			set { fastFoodtxt = value; OnPropertyChanged();}
		}

		private bool checkFastFood;

		public bool CheckFastFood
        {
			get { return checkFastFood; }
			set { checkFastFood = value; OnPropertyChanged(); }
		}

		private BitmapImage pathKartinkiOvoshi;

		public BitmapImage PathKartinkiOvoshi
        {
			get { return pathKartinkiOvoshi; }
			set { pathKartinkiOvoshi = value; OnPropertyChanged(); }
		}

		private string ovoshitxt;

		public string Ovoshitxt
        {
			get { return ovoshitxt; }
			set { ovoshitxt = value; OnPropertyChanged();}
		}

        private bool checkOvoshi;

        public bool CheckOvoshi
        {
            get { return checkOvoshi; }
            set { checkOvoshi = value; OnPropertyChanged(); }
        }

        private BitmapImage pathKartinkiMeet;

		public BitmapImage PathKartinkiMeet
        {
			get { return pathKartinkiMeet; }
			set { pathKartinkiMeet = value; OnPropertyChanged(); }
		}

		private string meettxt;

		public string Meettxt
        {
			get { return meettxt; }
			set { meettxt = value; OnPropertyChanged();}
		}

        private bool checkMeet;

        public bool CheckMeet
        {
            get { return checkMeet; }
            set { checkMeet = value; OnPropertyChanged(); }
        }

        private BitmapImage pathKartinkiFish;

		public BitmapImage PathKartinkiFish
        {
			get { return pathKartinkiFish; }
			set { pathKartinkiFish = value; OnPropertyChanged(); }
		}

		private string fishtxt;

		public string Fishtxt
		{
			get { return fishtxt; }
			set { fishtxt = value; OnPropertyChanged();}
		}

        private bool checkFish;

        public bool CheckFish
        {
            get { return checkFish; }
            set { checkFish = value; OnPropertyChanged(); }
        }

        private BitmapImage pathKartinkiFruit;

		public BitmapImage PathKartinkiFruit
        {
			get { return pathKartinkiFruit; }
			set { pathKartinkiFruit = value; OnPropertyChanged(); }
		}

		private string fruittxt;

		public string Fruittxt
        {
			get { return fruittxt; }
			set { fruittxt = value; OnPropertyChanged();}
		}

        private bool checkFruit;

        public bool CheckFruit
        {
            get { return checkFruit; }
            set { checkFruit = value; OnPropertyChanged(); }
        }

		private List<ViborModel> viborList = new List<ViborModel>();
		private List<ViborNaDayModel> viborNaDayList = new List<ViborNaDayModel>();
		Converter Converter = new Converter();
        public Menu_changeVM()
		{
			PathKartinkiFastFood = new BitmapImage(new Uri("../../WIN_20230411_22_42_47_Pro.jpg", UriKind.Relative));
			FastFoodtxt = "Фаст фуд";
            PathKartinkiOvoshi = new BitmapImage(new Uri("../../WIN_20230921_17_14_43_Pro.jpg", UriKind.Relative));
			Ovoshitxt = "Овощи";
            PathKartinkiMeet = new BitmapImage(new Uri("../../WIN_20230711_20_13_04_Pro.jpg", UriKind.Relative));
            Meettxt = "Мясо";
            PathKartinkiFish = new BitmapImage(new Uri("../../WIN_20230711_20_12_13_Pro.jpg", UriKind.Relative));
			Fishtxt = "Рыба";
            PathKartinkiFruit = new BitmapImage(new Uri("../../WIN_20230315_23_07_05_Pro.jpg", UriKind.Relative));
			Fruittxt = "Фрукты";
			Selected = new BindingClick(Select);
            Save = new BindingClick(_ => SaveClick());
            //viborNaDay = Converter.Jsonviser<List<ViborNaDayModel>>("Выборы");
            //выбирать из viborNaDay нужный viborList на день и присваивать viborList нужный да
        }

        public void Select(object nomer)
		{
			switch (nomer)
			{
				case "FastFood":
					if(CheckFastFood == true)
					{
						ViborModel vibor = new ViborModel(FastFoodtxt, PathKartinkiFastFood.ToString(), CheckFastFood);
						viborList.Add(vibor);
                    }
					else
					{
						foreach (var item in viborList)
						{
							if(item.name == "Фаст фуд")
							{
								item.selected = false;
							}
						}
					}
					break;
				case "Ovoshi":
                    if (CheckOvoshi == true)
                    {
                        ViborModel vibor = new ViborModel(Ovoshitxt, PathKartinkiOvoshi.ToString(), CheckOvoshi);
                        viborList.Add(vibor);
                    }
                    else
                    {
                        foreach (var item in viborList)
                        {
                            if (item.name == "Овощи")
                            {
                                item.selected = false;
                            }
                        }
                    }
                    break;
				case "Meet":
                    if (CheckMeet == true)
                    {
                        ViborModel vibor = new ViborModel(Meettxt, PathKartinkiMeet.ToString(), CheckMeet);
                        viborList.Add(vibor);
                    }
                    else
                    {
                        foreach (var item in viborList)
                        {
                            if (item.name == "Мясо")
                            {
                                item.selected = false;
                            }
                        }
                    }
                    break;
				case "Fish":
                    if (CheckFish == true)
                    {
                        ViborModel vibor = new ViborModel(Fishtxt, PathKartinkiFish.ToString(), CheckFish);
                        viborList.Add(vibor);
                    }
                    else
                    {
                        foreach (var item in viborList)
                        {
                            if (item.name == "Рыба")
                            {
                                item.selected = false;
                            }
                        }
                    }
                    break;
				case "Fruit":
                    if (CheckFruit == true)
                    {
                        ViborModel vibor = new ViborModel(Fruittxt, PathKartinkiFruit.ToString(), CheckFruit);
                        viborList.Add(vibor);
                    }
                    else
                    {
                        foreach (var item in viborList)
                        {
                            if (item.name == "Мясо")
                            {
                                item.selected = false;
                            }
                        }
                    }
                    break;
			}
		}
        public void SaveClick()
        {
            ViborNaDayModel viborNaDay = new ViborNaDayModel(DateTime.Now,viborList);
            viborNaDayList.Add(viborNaDay);
            Converter.Jsonser(viborNaDayList, "MyMood.json");
        }
	}
}
