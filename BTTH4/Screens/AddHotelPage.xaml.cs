using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace BTTH4
{
    public partial class AddHotelPage : ContentPage
    {
        City cityGlobal;
        public AddHotelPage()
        {
            InitializeComponent();
            PickerInit();
        }

        public AddHotelPage(City city)
        {
            InitializeComponent();
            cityGlobal = city;
            PickerInit();
        }

        void PickerInit()
        {
            Database db = new Database();

            List<City> cities = db.GetCities();
            PkrCity.ItemsSource = cities;
            
            foreach (City ct in cities)
            {
                if (cityGlobal.cityID == ct.cityID)
                {
                    PkrCity.SelectedIndex = cities.IndexOf(ct);
                    break;
                }
            }
        }

        void CmdAddNewHotel_Clicked(System.Object sender, System.EventArgs e)
        {
            Hotel newHotel = new Hotel();
            newHotel.hotelName = hotelNameTxt.Text;
            newHotel.hotelImg = hotelImgTxt.Text;

            City selectedCity = (City)PkrCity.SelectedItem;

            newHotel.cityID = selectedCity.cityID;

            Database db = new Database();

            if (db.AddNewHotel(newHotel))
            {
                DisplayAlert("Message", "Them Khach San Thanh Cong", "OK");
                Navigation.PushAsync(new HotelPage(selectedCity));
            } else
            {
                DisplayAlert("Error", "Them Khach San That Bai", "OK");
            }
        }
    }
}
