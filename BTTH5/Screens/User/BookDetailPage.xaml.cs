using System;
using System.Collections.Generic;
using BTTH5.DatabaseManager;
using BTTH5.Models;
using Xamarin.Forms;

namespace BTTH5.Screens.User
{
    public partial class BookDetailPage : ContentPage
    {
        Book currentBook;
        public BookDetailPage()
        {
            InitializeComponent();
        }

        public BookDetailPage(Book book)
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

        void AddToCartBtn_Clicked(System.Object sender, System.EventArgs e)
        {
            Cart newCart = new Cart();
            newCart.bookID = currentBook.bookID;
            newCart.totalAmount = currentBook.price;

            Database db = new Database();

            if (db.AddToCart(newCart))
            {
                DisplayAlert("Message", "Add successfully", "OK");

                Navigation.PushAsync(new UserPage());
            }
            else
            {
                DisplayAlert("Error", "Failed to add. Maybe this book is existed. Please check and try again.", "OK");
            }
        }
    }
}
