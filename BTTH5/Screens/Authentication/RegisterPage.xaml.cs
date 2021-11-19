using System;
using System.Collections.Generic;
using BTTH5.DatabaseManager;
using BTTH5.Models;
using Xamarin.Forms;

namespace BTTH5.Screens.Authentication
{
    public partial class RegisterPage : ContentPage
    {
        public RegisterPage()
        {
            InitializeComponent();
        }

        void CmdRegister_Clicked(System.Object sender, System.EventArgs e)
        {
            UserModel newUser = new UserModel();
            newUser.userName = userNameTxt.Text;
            newUser.userPassword = passwordTxt.Text;

            Database db = new Database();

            if (db.Register(newUser))
            {
                DisplayAlert("Message", "Register successfully", "OK");

                Navigation.PushAsync(new MainPage());
            }
            else
            {
                DisplayAlert("Error", "Failed to register", "OK");
            }
        }
    }
}
