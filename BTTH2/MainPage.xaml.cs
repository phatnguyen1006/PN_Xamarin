using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BTTH2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void ListView_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new ListView());
        }

        void Booking_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new Booking());
        }

        void Animal_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new AnimalTemplate());
        }
    }
}
