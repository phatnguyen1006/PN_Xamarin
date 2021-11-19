using System;
using System.Collections.Generic;
using BTTH5.DatabaseManager;
using BTTH5.Models;
using Xamarin.Forms;

namespace BTTH5.Screens.Admin
{
    public partial class UpdateBookPage : ContentPage
    {
        Book updatingBook;
        public UpdateBookPage(Book book)
        {
            InitializeComponent();
            updatingBook = book;
            present();
        }

        void present()
        {
            bookNameTxt.Text = updatingBook.bookName;
            bookImgTxt.Text = updatingBook.bookImg;
            bookPriceTxt.Text = updatingBook.price.ToString();
        }

        void CmdupdateBook_Clicked(System.Object sender, System.EventArgs e)
        {

            Book newBook = new Book();
            newBook.bookID = updatingBook.bookID;
            newBook.bookName = bookNameTxt.Text;
            newBook.bookImg = bookImgTxt.Text;
            newBook.price = int.Parse(bookPriceTxt.Text);

            Database db = new Database();

            if (db.updateBook(newBook))
            {
                DisplayAlert("Message", "Update successfully", "OK");

                Navigation.PushAsync(new AdminPage());
            }
            else
            {
                DisplayAlert("Error", "Failed to update", "OK");
            }
        }
    }
}
