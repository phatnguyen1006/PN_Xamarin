using System;
using SQLite;

namespace BTTH5.Models
{
    public class Cart
    {
        [PrimaryKey, AutoIncrement]
        public int cartID { get; set; }
        public int bookID { get; set; }
        public int totalAmount { get; set; }
    }
}
