using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace BTTH3
{
    public partial class BT3 : ContentPage
    {
        public BT3()
        {
            InitializeComponent();
            CountryInit();
            ListViewInit("");
        }

        List<Country> countries = new List<Country>();

        void CountryInit()
        {
            countries.Add(new Country("Tat ca"));
            countries.Add(new Country("Viet Nam"));
            countries.Add(new Country("Phap"));
            countries.Add(new Country("Uc"));

            PrkCountry.ItemsSource = countries;
        }

        string[] cityListImg = new string[]
        {
            "https://www.vietnam-briefing.com/news/wp-content/uploads/2019/03/Ho-Chi-Minh-City-1.jpg",
            "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQtUv8Jru7weK6ue_gS2YAB8Qrw9868vItugEBw6rH20ZJGvKO0W1NcBbJNzNHOb_wZTJY&usqp=CAU",
            "https://www.worldatlas.com/r/w768/upload/b3/ae/03/da-lat-city.jpg",
            "https://img.freepik.com/free-photo/paris-eiffel-tower-skyline-aerial-france_79295-14918.jpg?size=626&ext=jpg",
            "https://media.istockphoto.com/photos/view-of-the-old-port-of-marseille-france-picture-id928497156?k=20&m=928497156&s=612x612&w=0&h=5HnjeEp3E__ENvrnUjtWSPanGJY6SuGcfxzKvGMYRjo=",
            "https://alouc.com/wp-content/uploads/2016/08/img.jpg",
            "https://media.istockphoto.com/photos/me-princes-br-morning-light-picture-id876026224?k=20&m=876026224&s=612x612&w=0&h=iZ5KPumcpnUWS1G3ciuALn-1y6xH9rZN7v2K9zPCii4=",
        };

        void ListViewInit(string countryName)
        {
            List<City> cities = new List<City>();

            cities.Add(new City { cityName = "Ho Chi Minh", cityImg = cityListImg[0], country = "Viet Nam" });
            cities.Add(new City { cityName = "Ha Noi", cityImg = cityListImg[1], country = "Viet Nam" });
            cities.Add(new City { cityName = "Da Lat", cityImg = cityListImg[2], country = "Viet Nam" });

            cities.Add(new City { cityName = "Paris", cityImg = cityListImg[3], country = "Phap" });
            cities.Add(new City { cityName = "Marseille", cityImg = cityListImg[4], country = "Phap" });

            cities.Add(new City { cityName = "Sydney", cityImg = cityListImg[5], country = "Uc" });
            cities.Add(new City { cityName = "Melbourne", cityImg = cityListImg[6], country = "Uc" });

            if (countryName == "" || countryName == "Tat ca")
            {
                LstSelectedCountry.ItemsSource = cities;
            }
            else
            {
                List<City> selectedCity = new List<City>();

                foreach(City city in cities)
                {
                    if (city.country == countryName)
                    {
                        selectedCity.Add(city);
                    }
                }

                LstSelectedCountry.ItemsSource = selectedCity;
            }
        }

        void PrkCountry_SelectedIndexChanged(System.Object sender, System.EventArgs e)
        {
            var picker = (Picker)sender;

            int selectedCountryIndex = picker.SelectedIndex;

            if (selectedCountryIndex >= 0)
            {
                string countryName = picker.Items[selectedCountryIndex].ToString();

                ListViewInit(countryName);
            }
        }
    }
}
