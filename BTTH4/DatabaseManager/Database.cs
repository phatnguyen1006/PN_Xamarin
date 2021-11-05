using System;
using System.Collections.Generic;
using SQLite;
namespace BTTH4
{
    public class Database
    {
        string folder = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);

        public bool CreateDatabase()
        {
            try
            {

                // Create DB
                string path = System.IO.Path.Combine(folder, "BookingDatabase.db");
                var connection = new SQLiteConnection(path);

                // Create Table
                connection.CreateTable<City>();
                connection.CreateTable<Hotel>();

                return true;
            }
            catch (SQLiteException ex)
            {
                return false;
                throw;
            }
        }

        public bool AddNewCity(City city)
        {
            try
            {
                string path = System.IO.Path.Combine(folder, "BookingDatabase.db");
                var connection = new SQLiteConnection(path);

                connection.Insert(city);

                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public List<City> GetCities()
        {
            try
            {
                string path = System.IO.Path.Combine(folder, "BookingDatabase.db");
                var connection = new SQLiteConnection(path);

                return connection.Table<City>().ToList();

            }
            catch (Exception)
            {
                return null;
                throw;
            }
        }

        public List<Hotel> GetHotelsByCityID(int cityID)
        {
            try
            {
                string path = System.IO.Path.Combine(folder, "BookingDatabase.db");
                var connection = new SQLiteConnection(path);

                return connection.Query<Hotel>("select * from Hotel where cityID=" + cityID.ToString());

            }
            catch (Exception)
            {
                return null;
                throw;
            }
        }

        public bool AddNewHotel(Hotel hotel)
        {
            try
            {
                string path = System.IO.Path.Combine(folder, "BookingDatabase.db");
                var connection = new SQLiteConnection(path);

                connection.Insert(hotel);

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
                string path = System.IO.Path.Combine(folder, "BookingDatabase.db");
                var connection = new SQLiteConnection(path);

                connection.DeleteAll<City>();
                connection.DeleteAll<Hotel>();

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
