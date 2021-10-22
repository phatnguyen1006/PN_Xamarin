using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace BTTH3
{
    public partial class BT1 : ContentPage
    {
        public BT1()
        {
            InitializeComponent();
            InitCountryList();
            LstCountry.ItemsSource = countryList;
        }

        List<Country> countryList = new List<Country>();

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

        void InitCountryList()
        {
            Country VietNam = new Country("Viet Nam");
            VietNam.Add(new City { cityName = "Ho Chi Minh", cityImg = cityListImg[0] });
            VietNam.Add(new City { cityName = "Ha Noi", cityImg = cityListImg[1] });
            VietNam.Add(new City { cityName = "Da Lat", cityImg = cityListImg[2] });

            countryList.Add(VietNam);
            Country France = new Country("Phap");
            France.Add(new City { cityName = "Paris", cityImg = cityListImg[3] });
            France.Add(new City { cityName = "Marseille", cityImg = cityListImg[4] });

            countryList.Add(France);

            Country Australia = new Country("Uc");
            Australia.Add(new City { cityName = "Sydney", cityImg = cityListImg[5] });
            Australia.Add(new City { cityName = "Melbourne", cityImg = cityListImg[6] });

            countryList.Add(Australia);


        }
    }
}
