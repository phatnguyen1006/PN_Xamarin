using System;
using SQLite;

namespace BTTH5.Models
{
    public class Book
    {
        [PrimaryKey, AutoIncrement]
        public int bookID { get; set; }
        public string bookName { get; set; }
        public string bookImg { get; set; }
        public int price { get; set; }
    }
}
