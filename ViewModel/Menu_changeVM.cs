using pract6Kalendar.Model;
using pract6Kalendar.ViewModel.Helperi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
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
			PathKartinkiFastFood = new BitmapImage(new Uri("../../msg984776183-261182.jpg", UriKind.Relative));
			FastFoodtxt = "Влюбленный ❤";
            PathKartinkiOvoshi = new BitmapImage(new Uri("../../msg984776183-261194.jpg", UriKind.Relative));
			Ovoshitxt = "Охота навести суету 🤙";
            PathKartinkiMeet = new BitmapImage(new Uri("../../msg984776183-261197.jpg", UriKind.Relative));
            Meettxt = "Все плохо 🤧";
            PathKartinkiFish = new BitmapImage(new Uri("../../msg984776183-261202.jpg", UriKind.Relative));
			Fishtxt = "Деловой 💻";
            PathKartinkiFruit = new BitmapImage(new Uri("../../msg984776183-261204.jpg", UriKind.Relative));
			Fruittxt = "Голодный 🍔";
			Selected = new BindingClick(Select);
            Save = new BindingClick(_ => SaveClick());
            viborNaDayList = Converter.Jsonviser<List<ViborNaDayModel>>("MyMood.json") ?? new List<ViborNaDayModel>();
            MainWindow window = Application.Current.MainWindow as MainWindow;
            DateTime date = DateTime.Parse(window.vm.DataKakayato);
            foreach (var item in viborNaDayList)
            {
                if(item.data == date)
                {
                    viborList = item.viborModels;
                }
            }
            foreach (var item in viborList)
            {
                if(item.name == "Влюбленный ❤")
                {
                    CheckFastFood = item.selected;
                }
                else if(item.name == "Охота навести суету \U0001f919")
                {
                    CheckOvoshi = item.selected;
                }
                else if(item.name == "Все плохо 🤧")
                {
                    CheckMeet = item.selected;
                }
                else if(item.name == "Деловой 💻")
                {
                    CheckFish = item.selected;
                }
                else if(item.name == "Голодный 🍔")
                {
                    CheckFruit = item.selected;
                }
            }
            if(viborList.Count == 0)
            {
                ViborModel Fastfood = new ViborModel(FastFoodtxt, PathKartinkiFastFood.ToString(), CheckFastFood);
                viborList.Add(Fastfood);
                ViborModel Ovoshi = new ViborModel(Ovoshitxt, PathKartinkiOvoshi.ToString(), CheckOvoshi);
                viborList.Add(Ovoshi);
                ViborModel Meet = new ViborModel(Meettxt, PathKartinkiMeet.ToString(), CheckMeet);
                viborList.Add(Meet);
                ViborModel Fish = new ViborModel(Fishtxt, PathKartinkiFish.ToString(), CheckFish);
                viborList.Add(Fish);
                ViborModel Fruit = new ViborModel(Fruittxt, PathKartinkiFruit.ToString(), CheckFruit);
                viborList.Add(Fruit);
            }
            //выбирать из viborNaDay нужный viborList на день и присваивать viborList нужный да
        }

        public void Select(object nomer)
		{
			switch (nomer)
			{
				case "FastFood":
					if(CheckFastFood == true)
					{
                        foreach (var item in viborList)
                        {
                            if (item.name == "Влюбленный ❤")
                            {
                                item.selected = true;
                            }
                        }
                    }
					else
					{
						foreach (var item in viborList)
						{
							if(item.name == "Влюбленный ❤")
							{
								item.selected = false;
							}
						}
					}
					break;
				case "Ovoshi":
                    if (CheckOvoshi == true)
                    {
                        foreach (var item in viborList)
                        {
                            if (item.name == "Охота навести суету \U0001f919")
                            {
                                item.selected = true;
                            }
                        }
                    }
                    else
                    {
                        foreach (var item in viborList)
                        {
                            if (item.name == "Охота навести суету \U0001f919")
                            {
                                item.selected = false;
                            }
                        }
                    }
                    break;
				case "Meet":
                    if (CheckMeet == true)
                    {
                        foreach (var item in viborList)
                        {
                            if (item.name == "Все плохо \U0001f927")
                            {
                                item.selected = true;
                            }
                        }
                    }
                    else
                    {
                        foreach (var item in viborList)
                        {
                            if (item.name == "Все плохо \U0001f927")
                            {
                                item.selected = false;
                            }
                        }
                    }
                    break;
				case "Fish":
                    if (CheckFish == true)
                    {
                        foreach (var item in viborList)
                        {
                            if (item.name == "Деловой 💻")
                            {
                                item.selected = true;
                            }
                        }
                    }
                    else
                    {
                        foreach (var item in viborList)
                        {
                            if (item.name == "Деловой 💻")
                            {
                                item.selected = false;
                            }
                        }
                    }
                    break;
				case "Fruit":
                    if (CheckFruit == true)
                    {
                        foreach (var item in viborList)
                        {
                            if (item.name == "Голодный 🍔")
                            {
                                item.selected = true;
                            }
                        }
                    }
                    else
                    {
                        foreach (var item in viborList)
                        {
                            if (item.name == "Голодный 🍔")
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

            MainWindow window = Application.Current.MainWindow as MainWindow;
            DateTime date = DateTime.Parse(window.vm.DataKakayato);
            for (int i = 0; i < viborNaDayList.Count; i++)
            {
                if (viborNaDayList[i].data == date)
                {
                    viborNaDayList.Remove(viborNaDayList[i]);
                    Converter.Jsonser(viborNaDayList, "MyMood.json");
                }
            }
            ViborNaDayModel viborNaDay = new ViborNaDayModel(date,viborList);
            viborNaDayList.Add(viborNaDay);
            Converter.Jsonser(viborNaDayList, "MyMood.json");
        }
	}
}
