using System;
using System.Collections.Generic;
using System.Text;

namespace CountriesLab
{
    class Country
    {
        private string _name;
        private string _continent;
        private List<string> _colors;

        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        public string Continent
        {
            get { return this._continent; }
            set { this._continent = value; }
        }

        public List<string> Colors
        {
            get { return this._colors; }
            set { this._colors = value; }
        }

        public Country(string name, string continent, List<string> colors)
        {
            this._name = name;
            this._continent = continent;
            List<string> _colors = colors;
        }

        public override string ToString()
        {
            return $"Name: {this._name} Continent: {this._continent} Colors: {this._colors} ";
        }
    }
}
