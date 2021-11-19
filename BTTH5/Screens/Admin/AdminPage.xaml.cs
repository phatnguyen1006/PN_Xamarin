using System;
using System.Collections.Generic;
using BTTH5.DatabaseManager;
using BTTH5.Models;
using BTTH5.Screens.Admin;
using Xamarin.Forms;

namespace BTTH5.Screens
{
    public partial class AdminPage : ContentPage
    {
        public AdminPage()
        {
            InitializeComponent();
            NavigationPage.SetHasBackButton(this, false);
            AdminPageInit();
        }

        void AdminPageInit()
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

        void AddBookBtn_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new AddNewBook());
        }

        void ListBook_ItemSelected(System.Object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            if (ListBook.SelectedItem != null)
            {
                Book book = (Book)ListBook.SelectedItem;
                Navigation.PushAsync(new AdminBookDetailPage(book));
            }
        }

        void LogOut_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }
    }
}
