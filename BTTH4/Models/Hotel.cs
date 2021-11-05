using System;
using SQLite;
namespace BTTH4
{
    public class Hotel
    {
        [PrimaryKey, AutoIncrement]
        public int hotelID { get; set; }
        public string hotelName { get; set; }
        public string hotelImg { get; set; }
        public int cityID { get; set; }
    }
}
