using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BTTH4
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            //db.DropDatabase();
            ListViewInit();
        }

        void ListViewInit()
        {
            Database db = new Database();

            List<City> cities = db.GetCities();

            ListCity.ItemsSource = cities;
        }


        void CmdAddCity_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new AddCityPage());
        }

        void ListCity_ItemSelected(System.Object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            City selectedCity = (City)ListCity.SelectedItem;

            Navigation.PushAsync(new HotelPage(selectedCity));
        }
    }
}
