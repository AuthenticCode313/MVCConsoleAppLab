using System;
using System.Collections.Generic;
using System.Text;

namespace CountriesLab
{
    class CountryListView
    {
        private List<Country> _countries;

        public List<Country> Countries
        {
            get { return this._countries; }
            set { this._countries = value; }
        }
        public CountryListView(List<Country> countries)
        {
            this._countries = countries;
        }

        public void Display()
        {
            for(int i = 0; i < _countries.Count; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
