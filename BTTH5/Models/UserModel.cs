using System;
using SQLite;

namespace BTTH5.Models
{
    public class UserModel
    {
        [PrimaryKey, AutoIncrement]
        public int userID { get; set; }
        public string userName { get; set; }
        public string userPassword { get; set; }
    }
}
