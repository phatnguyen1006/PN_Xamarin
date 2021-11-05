using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace BTTH4
{
    public partial class AddCityPage : ContentPage
    {
        public AddCityPage()
        {
            InitializeComponent();
        }

        void CmdAddNewCity_Clicked(System.Object sender, System.EventArgs e)
        {
            City newCity = new City();
            newCity.cityName = cityNameTxt.Text;
            newCity.cityImg = cityImgTxt.Text;

            Database db = new Database();

            if (db.AddNewCity(newCity))
            {
                DisplayAlert("Message", "Them moi thanh cong", "OK");

                Navigation.PushAsync(new MainPage());
            } else
            {
                DisplayAlert("Error", "Them moi that bai", "OK");
            }


        }
    }
}
