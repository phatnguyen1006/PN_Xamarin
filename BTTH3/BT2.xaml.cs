using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace BTTH3
{
    public partial class BT2 : ContentPage
    {
        public BT2()
        {
            InitializeComponent();
            BookInt();
        }

        List<Book> books = new List<Book>();

        string[] bookListImg = new string[]
        {
            "https://salt.tikicdn.com/media/catalog/product/d/a/dacnhantam.jpg",
            "https://media3.scdn.vn/img3/2019/3_3/qYc80A_simg_de2fe0_500x500_maxb.jpg",
            "https://sachhoc.com/image/cache/catalog/Chuyennganh/Kinhte-quanly/Nha-gia-kim-500x554.jpg",
            "https://sachhaynendoc.net/wp-content/uploads/2019/02/mb.png",
        };

        void BookInt()
        {
            books.Add(new Book { bookTitle = "Dac Nhan Tam", bookImg = bookListImg[0] });
            books.Add(new Book { bookTitle = "Hieu Ve Trai Tim", bookImg = bookListImg[1] });
            books.Add(new Book { bookTitle = "Nha Gia Kim", bookImg = bookListImg[2] });
            books.Add(new Book { bookTitle = "Mat Biet", bookImg = bookListImg[3] });

            PrkBook.ItemsSource = books;
        }

        void CartInit(string title)
        {
            List<Book> selectedBook = new List<Book>();

            if (title != "")
            {
                foreach (Book book in books)
                {
                    if (book.bookTitle == title)
                    {
                        selectedBook.Add(book);
                    }
                }

                LstSelectedBook.ItemsSource = selectedBook;
            }
        }

        void PrkBook_SelectedIndexChanged(System.Object sender, System.EventArgs e)
        {
            var picker = (Picker)sender;
            int selectedBookIndex = picker.SelectedIndex;

            if (selectedBookIndex >= 0)
            {
                string selectedBookTitle = picker.Items[selectedBookIndex].ToString();

                CartInit(selectedBookTitle);
            }
        }

    }
}
