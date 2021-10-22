using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace BTTH3
{
    public partial class BT4 : ContentPage
    {
        public BT4()
        {
            InitializeComponent();
            InitScreen();
        }

        void initRemindMe()
        {
            string[] remindTime = new string[]
            {
                "One hour before",
                "Twelve hours before",
                "One day before",
                "Three day before",
                "One week before",
            };

            PrkRemind.ItemsSource = remindTime;
            PrkRemind.SelectedIndex = 0;
        }

        string[] listImgVehicle = new string[]
        {
            "https://5.imimg.com/data5/LH/VX/MY-39773621/avon-trux-bicycles-500x500.jpg",
            "https://img.freepik.com/free-psd/three-dimensional-image-car_53876-1716.jpg?size=626&ext=jpg",
            "https://imgboats.com/assets/images/product_2.jpg",
            "https://www.englishelectric.org.uk/img/s/v-10/p1832712697-3.jpg",
            "https://media.istockphoto.com/photos/commercial-jet-flying-over-clouds-picture-id155380716?b=1&k=20&m=155380716&s=170667a&w=0&h=LjalFiyrKtBye-26dufNMHkbU_k_KrJ1-UYnbTpaxtM=",
        };


        void initListVehicle()
        {
            string[] listVehicle = new string[]
            {
                "Bicycles",
                "Cars",
                "Ships",
                "Trains",
                "Airplanes",
            };

            PrkVehicle.ItemsSource = listVehicle;
            PrkVehicle.SelectedIndex = 1;
            ImgVehicle.Source = listImgVehicle[1];
        }

        void initInterval()
        {
            string[] listInterval = new string[]
            {
                "3-Month",
                "Half Yearly",
                "12-Month",
                "18-Month",
                "2-Year",
                "5-Year",
            };

            PrkInterval.ItemsSource = listInterval;
            PrkInterval.SelectedIndex = 0;
        }


        void InitScreen()
        {
            initRemindMe();
            initListVehicle();
            initInterval();
        }

        void updateImg(int index)
        {
            ImgVehicle.Source = listImgVehicle[index];
        }

        void PrkVehicle_SelectedIndexChanged(System.Object sender, System.EventArgs e)
        {
            var picker = (Picker)sender;

            int selectedVehicleIndex = picker.SelectedIndex;

            if (selectedVehicleIndex >= 0)
            {
                updateImg(selectedVehicleIndex);
            }
        }

        void SubmitBtn_Clicked(System.Object sender, System.EventArgs e)
        {
            var name = vehicleName.Text;
            var regNo = vehicleReg.Text;
            var vehicleType = PrkVehicle.SelectedItem;
            var svLast = PrkLastS.Date.ToString("dd/MM/yyyy");
            var svInterval = PrkInterval.SelectedItem;
            var svNext = PrkNextS.Date.ToString("dd/MM/yyyy");
            var remind = reminder.IsToggled ? true : false;
            var remindTime = PrkRemind.SelectedItem;

            var message = "Name: " + name + "\nRegNo: " + regNo + "\nType" + vehicleType + "\nLast Service: " + svLast + "\nService Interval: " + svInterval + "\nNext Service: " + svNext;
            var remindMess = remind ? "\nWe will remind you " + remindTime : "\nWe won't remind you. Thank you!";


            DisplayAlert("Vehicle Information", message + remindMess, "OK");
        }
    }
}
