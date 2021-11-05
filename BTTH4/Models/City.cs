using System;
using SQLite;
namespace BTTH4
{
    public class City
    {
        [PrimaryKey, AutoIncrement]
        public int cityID { get; set; }
        public string cityName { get; set; }
        public string cityImg { get; set; }
    }
}
