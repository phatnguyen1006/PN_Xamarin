using System;
using System.Collections.Generic;
using BTTH5.DatabaseManager;
using BTTH5.Models;
using Xamarin.Forms;

namespace BTTH5.Screens.Admin
{
    public partial class AddNewBook : ContentPage
    {
        public AddNewBook()
        {
            InitializeComponent();
        }

        void CmdAddNewBook_Clicked(System.Object sender, System.EventArgs e)
        {
            Book newBook = new Book();
            newBook.bookName = bookNameTxt.Text;
            newBook.bookImg = bookImgTxt.Text;
            newBook.price = int.Parse(bookPriceTxt.Text);

            Database db = new Database();

            if (db.AddNewBook(newBook))
            {
                DisplayAlert("Message", "Add successfully", "OK");

                Navigation.PushAsync(new AdminPage());
            }
            else
            {
                DisplayAlert("Error", "Failed to add", "OK");
            }
        }
    }
}
