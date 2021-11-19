using System;
using System.Collections.Generic;
using BTTH5.DatabaseManager;
using BTTH5.Models;
using Xamarin.Forms;

namespace BTTH5.Screens.User
{
    public partial class ActionInCart : ContentPage
    {
        Book currentBook;
        public ActionInCart(Book book)
        {
            InitializeComponent();
            currentBook = book;
            presentBook();
        }

        void presentBook()
        {
            Title = currentBook.bookName;
            BookImage.Source = currentBook.bookImg;
            BookName.Text = currentBook.bookName;
            BookPrice.Text = currentBook.price.ToString();
        }

        void RemoveFromCartBtn_Clicked(System.Object sender, System.EventArgs e)
        {

            Device.BeginInvokeOnMainThread(async () =>
            {

                // remove from database
                Database db = new Database();
                var userChoice = await DisplayAlert("Message", "Are you sure to remove", "YES", "NO");

                if (userChoice)
                {
                    if (db.removeFromCart(currentBook.bookID))
                    {
                        await DisplayAlert("Message", "Remove form cart successfully", "OK");

                        await Navigation.PushAsync(new UserPage());
                    }
                    else
                    {
                        await DisplayAlert("Message", "Failed to remove.", "OK");
                    }
                }
            });
        }
    }
}
