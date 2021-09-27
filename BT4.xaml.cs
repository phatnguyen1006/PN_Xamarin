using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace First
{
    public partial class BT4 : ContentPage
    {
        public BT4()
        {
            InitializeComponent();
        }

        void Submit_Clicked(System.Object sender, System.EventArgs e)
        {
            var usrNameValue = usrName.Text;
            var usrEmailValue = usrEmail.Text;
            var usrDOBValue = usrDOB.Date.ToString("dd/MM/yyyy");
            var isMale = usrGender.IsToggled;
            var usrGenderValue = "";

            if (isMale)
            {
                usrGenderValue = "Male";
            }
            else
            {
                usrGenderValue = "Female";
            }

            var message = "Name: " + usrNameValue + "\nEmail: " + usrEmailValue + "\nBirthday" + usrDOBValue + "\nGender: " + usrGenderValue;

            DisplayAlert("User Information", message, "Ok");
        }

        void Cancel_Clicked(System.Object sender, System.EventArgs e)
        {
            usrName.Text = "";
            usrEmail.Text = "";
            usrDOB.Date = DateTime.Today;
            usrGender.IsToggled = false;
        }
    }
}
