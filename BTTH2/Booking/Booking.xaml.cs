using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace BTTH2
{
    public partial class Booking : ContentPage
    {
        public Booking()
        {
            InitializeComponent();
            CreateCityList();
            ListCity.ItemsSource = cityList;
        }

        List<City> cityList = new List<City>();

        void CreateCityList()
        {
            cityList.Add(new City
            {
                cityId = "HN",
                cityName = "Ha Noi",
                cityImg = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQtUv8Jru7weK6ue_gS2YAB8Qrw9868vItugEBw6rH20ZJGvKO0W1NcBbJNzNHOb_wZTJY&usqp=CAU"
            });

            cityList.Add(new City
            {
                cityId = "DL",
                cityName = "Da Lat",
                cityImg = "https://www.worldatlas.com/r/w768/upload/b3/ae/03/da-lat-city.jpg"
            });

            cityList.Add(new City
            {
                cityId = "HCM",
                cityName = "Ho Chi Minh",
                cityImg = "https://www.vietnam-briefing.com/news/wp-content/uploads/2019/03/Ho-Chi-Minh-City-1.jpg"
            });

            cityList.Add(new City
            {
                cityId = "VT",
                cityName = "Vung Tau",
                cityImg = "https://m.justgola.com/media/a/00/05/21597_og_1.jpeg"
            });
        }

        void ListCity_ItemSelected(System.Object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            if (ListCity.SelectedItem != null)
            {
                City city = (City)ListCity.SelectedItem;

                Navigation.PushAsync(new Hotels(city));
            }
        }
    }
}
