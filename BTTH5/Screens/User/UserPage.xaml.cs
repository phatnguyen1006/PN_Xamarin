using System;
using System.Collections.Generic;
using BTTH5.DatabaseManager;
using BTTH5.Models;
using BTTH5.Screens.User;
using Xamarin.Forms;

namespace BTTH5
{
    public partial class UserPage : ContentPage
    {
        public UserPage()
        {
            InitializeComponent();
            NavigationPage.SetHasBackButton(this, false);
            UserPageInit();
        }

        void UserPageInit()
        {
            Database db = new Database();
            List<Book> books = db.getAllBook();

            if (books == null)
            {
                ListBook.ItemsSource = null;
                return;
            }

            ListBook.ItemsSource = books;
        }

        void ListBook_ItemSelected(System.Object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            if (ListBook.SelectedItem != null)
            {
                Book book = (Book)ListBook.SelectedItem;
                Navigation.PushAsync(new BookDetailPage(book));
            }
        }

        void CartBtn_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new CartPage());
        }

        void LogOutBtn_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }
    }
}
