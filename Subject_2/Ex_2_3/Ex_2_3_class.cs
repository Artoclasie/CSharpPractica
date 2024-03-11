using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_2_3
{
    class Address
    {
        private string country;
        private string city;
        private string street;
        private int houseNumber;

        public void SetCountry(string newCountry)
        {
            if (!string.IsNullOrEmpty(newCountry))
            {
                country = newCountry;
            }
            else
            {
                Console.WriteLine("Неправильный ввод страны");
            }
        }

        public void SetCity(string newCity)
        {
            if (!string.IsNullOrEmpty(newCity))
            {
                city = newCity;
            }
            else
            {
                Console.WriteLine("Неправильный ввод города");
            }
        }

        public void SetStreet(string newStreet)
        {
            if (!string.IsNullOrEmpty(newStreet))
            {
                street = newStreet;
            }
            else
            {
                Console.WriteLine("Неправильный ввод улицы");
            }
        }

        public void SetHouseNumber(int newHouseNumber)
        {
            if (newHouseNumber > 0)
            {
                houseNumber = newHouseNumber;
            }
            else
            {
                Console.WriteLine("Неправильный ввод номера дома");
            }
        }

        public void DisplayAddress()
        {
            Console.WriteLine($"Страна: {country}, Город: {city}, Улица: {street}, Номер дома: {houseNumber}");
        }
    }
}
