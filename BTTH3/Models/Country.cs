using System;
using System.Collections.Generic;

namespace BTTH3
{
    public class Country : List<City>
    {
        public string countryName { get; set; }
        //public string countryImg { get; set; }

        public Country(string countryName)
        {
            this.countryName = countryName;
        }
    }
}
