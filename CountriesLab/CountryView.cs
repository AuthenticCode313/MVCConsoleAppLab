using System;
using System.Collections.Generic;
using System.Text;

namespace CountriesLab
{
    class CountryView
    {
        private Country _displayCountry;

        public Country DisplayCountry
        {
            get { return this._displayCountry; }
            set { this._displayCountry = value; }
        }
       
        public CountryView(Country country)
        {
            this._displayCountry = DisplayCountry;
            DisplayCountry = country;

        }

        public void Display()
        {
            Console.WriteLine(_displayCountry.ToString());
        }
    }
}
