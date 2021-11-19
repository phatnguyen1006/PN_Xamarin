using System;
using System.Collections.Generic;
using BTTH5.DatabaseManager;
using BTTH5.Models;
using BTTH5.Screens.Admin;
using Xamarin.Forms;

namespace BTTH5.Screens
{
    public partial class AdminBookDetailPage : ContentPage
    {
        Book currentBook;
        public AdminBookDetailPage()
        {
            InitializeComponent();
        }

        public AdminBookDetailPage(Book book)
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

        void UpdateBookBtn_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new UpdateBookPage(currentBook));
        }

        void DeleteBookBtn_Clicked(System.Object sender, System.EventArgs e)
        {
            Device.BeginInvokeOnMainThread(async () =>
            {

                // remove from database
                Database db = new Database();
                var userChoice = await DisplayAlert("Message", "Are you sure to delete", "YES", "NO");

                if (userChoice)
                {
                    if (db.deleteBook(currentBook.bookID))
                    {
                        await DisplayAlert("Message", "Delete successfully", "OK");

                        await Navigation.PushAsync(new UserPage());
                    }
                    else
                    {
                        await DisplayAlert("Message", "Failed to Delete", "OK");
                    }
                }
            });
        }
    }
}
