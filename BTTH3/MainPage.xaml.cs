using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BTTH3
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void BT1_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new BT1());
        }

        void BT2_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new BT2());
        }

        void BT3_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new BT3());
        }

        void BT4_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new BT4());
        }
    }
}
