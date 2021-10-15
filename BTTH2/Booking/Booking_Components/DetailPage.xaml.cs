using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace BTTH2
{
    public partial class DetailPage : ContentPage
    {
        public DetailPage(Hotel hotel)
        {
            InitializeComponent();
            Title = hotel.hotelName;

            HotelImage.Source = hotel.hotelImg;
            HotelName.Text = hotel.hotelName;
            HotelAddress.Text = hotel.hotelAddress;
            HotelDescription.Text = hotel.hotelDescript;
        }
    }
}
