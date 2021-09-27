using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace First
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void BT_1_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new BT1());
        }

        void BT_2_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new BT2());
        }

        void BT_3_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new BT3());
        }

        void BT_4_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new BT4());
        }

        void BT_5_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new BT5());
        }
    }
}
