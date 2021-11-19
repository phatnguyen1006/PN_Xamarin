using System;
using System.Collections.Generic;
using BTTH5.DatabaseManager;
using BTTH5.Models;
using Xamarin.Forms;

namespace BTTH5.Screens.User
{
    public partial class CartPage : ContentPage
    {
        public CartPage()
        {
            InitializeComponent();
            CartInit();
        }

        void CartInit()
        {
            Database db = new Database();
            List<Book> books = db.getBookInCart();

            if (books == null)
            {
                ListBookInCart.ItemsSource = null;
                return;
            }

            ListBookInCart.ItemsSource = books;
        }

        void ListBookInCart_ItemSelected(System.Object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            if (ListBookInCart.SelectedItem != null)
            {
                Book book = (Book)ListBookInCart.SelectedItem;
                Navigation.PushAsync(new ActionInCart(book));
            }
        }
    }
}
