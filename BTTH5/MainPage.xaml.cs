using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BTTH5.DatabaseManager;
using BTTH5.Screens;
using BTTH5.Screens.Authentication;
using Xamarin.Forms;

namespace BTTH5
{
    public partial class MainPage : ContentPage
    {
        bool isAdmin = false;
        public MainPage()
        {
            InitializeComponent();
            NavigationPage.SetHasBackButton(this, false);
        }

        void setAuth(bool isadmin)
        {
            isAdmin = isadmin;

            switchScreen();
        }

        void switchScreen()
        {
            if (isAdmin == true)
            {
                // Push to Admin Page
                Navigation.PushAsync(new AdminPage());
            }
            else
            {
                // Push to User Page
                Navigation.PushAsync(new UserPage());
            }
        }

        void AdminRegisterBtn_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new RegisterPage());
        }

        void UserLoginBtn_Clicked(System.Object sender, System.EventArgs e)
        {
            setAuth(false);
        }

        void CmdLogin_Clicked(System.Object sender, System.EventArgs e)
        {
            string userName = userNameTxt.Text;
            string password = passwordTxt.Text;

            Database db = new Database();

            if (db.LogIn(userName, password))
            {
                DisplayAlert("Message", "Login successfully", "OK");

                setAuth(true);
            }
            else
            {
                DisplayAlert("Message", "Failed to log in", "OK");
            }
        }
    }
}
