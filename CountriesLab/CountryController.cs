using System;
using System.Collections.Generic;
using System.Text;

namespace CountriesLab
{
    class CountryController
    {
        private List<Country> _countryDb;

        public List<Country> CountryDB
        {
            get { return this._countryDb; }
            set { this._countryDb = value; }
        }


        public CountryController()
        {

        }
        public void CountryAction(Country c)
        {
            CountryView cView = new CountryView(c);
            cView.Display();
            CountryListView llView = new CountryListView(CountryDB);
            llView.Display();
            Console.WriteLine("Would you like to learn about anothe country? y/n");
            string input = Console.ReadLine();

            bool loop = true;
            while (loop)
            {


                if (input == "y")
                {
                    loop = true;
                    break;
                }
                else if (input == "n")
                {
                    loop = false;
                    break;
                }
                else
                {
                    Console.WriteLine("That is not a y/n");
                }

            }

             
        }

        public void WelcomeAction()
        {
            CountryListView lView = new CountryListView(CountryDB);
            Console.WriteLine("Hello, welcome to the country app. Please select a country from the following list:");
            lView.Display();

                
        }
    }
}
