using System;
using System.Collections.Generic;
using BTTH5.Models;
using SQLite;

namespace BTTH5.DatabaseManager
{
    public class Database
    {
        string folder = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);

        public bool CreateDatabase()
        {
            try
            {

                // Create DB
                string path = System.IO.Path.Combine(folder, "LibraryDatabase.db");
                var connection = new SQLiteConnection(path);

                // Create Table
                connection.CreateTable<UserModel>();
                connection.CreateTable<Book>();
                connection.CreateTable<Cart>();

                return true;
            }
            catch (SQLiteException ex)
            {
                return false;
                throw;
            }
        }

        public bool Register(UserModel newUser)
        {
            try
            {
                string path = System.IO.Path.Combine(folder, "LibraryDatabase.db");
                var connection = new SQLiteConnection(path);

                connection.Insert(newUser);

                return true;

            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public bool LogIn(string name, string password)
        {
            try
            {
                string path = System.IO.Path.Combine(folder, "LibraryDatabase.db");
                var connection = new SQLiteConnection(path);

                //var checkingUser = connection.Query<UserModel>("SELECT * FROM UserModel WHERE userName="+userName.ToString());
                List<UserModel> checkingUser = connection.Table<UserModel>().ToList();

                if (checkingUser != null)
                {
                    foreach (UserModel user in checkingUser)
                    {
                        if (user.userName == name)
                        {
                            if (user.userPassword == password)
                            {
                                return true;
                            }

                            return false;
                        }

                        return false;
                    }
                }

                return false;
            }
            catch (Exception err)
            {
                return false;
                throw;
            }
        }

        public List<Book> getAllBook()
        {
            try
            {
                string path = System.IO.Path.Combine(folder, "LibraryDatabase.db");
                var connection = new SQLiteConnection(path);

                return connection.Table<Book>().ToList();

            }
            catch (Exception)
            {
                return null;
                throw;
            }
        }

        public bool AddNewBook(Book book)
        {
            try
            {
                string path = System.IO.Path.Combine(folder, "LibraryDatabase.db");
                var connection = new SQLiteConnection(path);

                connection.Insert(book);

                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public bool updateBook(Book book)
        {
            try
            {
                string path = System.IO.Path.Combine(folder, "LibraryDatabase.db");
                var connection = new SQLiteConnection(path);

                connection.Update(book);

                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public bool deleteBook(int bookid)
        {
            try
            {
                string path = System.IO.Path.Combine(folder, "LibraryDatabase.db");
                var connection = new SQLiteConnection(path);

                connection.Delete<Book>(bookid);

                // go to cart and delete that book
                connection.Query<Cart>("delete from Cart where bookID=" + bookid.ToString());

                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public List<Book> getBookInCart()
        {
            try
            {
                string path = System.IO.Path.Combine(folder, "LibraryDatabase.db");
                var connection = new SQLiteConnection(path);

                var cartItems = connection.Table<Cart>().ToList();
                List<Book> bookListInCart = new List<Book>();

                foreach(Cart cart in cartItems)
                {
                    if (cart.bookID != null)
                    {
                        List<Book> result = connection.Query<Book>("select * from Book where bookID=" + cart.bookID.ToString());
                        // Just 1 book, bc bookID is unique
                        if (result != null)
                        {
                            bookListInCart.Add(result[0]);
                        }
                    }
                }

                return bookListInCart;

            }
            catch (Exception)
            {
                return null;
                throw;
            }
        }

        // ***
        public bool removeFromCart(int bookid)
        {
            try
            {
                string path = System.IO.Path.Combine(folder, "LibraryDatabase.db");
                var connection = new SQLiteConnection(path);

                connection.Query<Cart>("delete from Cart where bookID=" + bookid.ToString());

                return true;

            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public bool AddToCart(Cart cart)
        {
            try
            {
                string path = System.IO.Path.Combine(folder, "LibraryDatabase.db");
                var connection = new SQLiteConnection(path);

                // middleware
                // check if bookId exists in Cart Table => false
                // check else => save
                var cartItems = connection.Table<Cart>().ToList();
                List<Book> bookListInCart = new List<Book>();

                foreach (Cart oldCart in cartItems)
                {
                    if (oldCart.bookID == cart.bookID)
                    {
                        return false;
                    }
                }


                connection.Insert(cart);

                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public bool DropDatabase()
        {
            try
            {
                string path = System.IO.Path.Combine(folder, "LibraryDatabase.db");
                var connection = new SQLiteConnection(path);

                connection.DeleteAll<UserModel>();
                connection.DeleteAll<Book>();
                connection.DeleteAll<Cart>();

                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }
    }
}
