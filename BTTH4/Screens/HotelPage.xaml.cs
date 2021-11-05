using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace BTTH4
{
    public partial class HotelPage : ContentPage
    {
        City cityGlobal;
        public HotelPage()
        {
            InitializeComponent();
        }

        public HotelPage(City city)
        {
            InitializeComponent();
            Title = city.cityName;
            cityGlobal = city;
            ListViewInit(city);
        }

        void ListViewInit(City city)
        {
            Database db = new Database();
            List<Hotel> hotels = db.GetHotelsByCityID(city.cityID);
            ListHotel.ItemsSource = hotels;
        }

        void CmdAddHotel_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new AddHotelPage(cityGlobal));
        }

        void ListHotel_ItemSelected(System.Object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
        }
    }
}
