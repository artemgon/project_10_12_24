
using System.Diagnostics;

namespace project_10_12_24.Classes
{
    internal class City
    {
        private string CityName { get; set; }
        public string CountryName { get; set; }
        public string PhoneCode { get; set; }
        public List<string> CityDistricts { get; set; }
        public int Population { get; set; }
        public string City_Name
        {
            private get => CityName;
            set => CityName = value;
        }
        public City()
        {
            CityName = "Unknown";
            CountryName = "Unknown";
            PhoneCode = "Unknown";
            CityDistricts = [];
            Population = 0;
        }
        public City(string name) : this()
        {
            CityName = name;
        }
        public City(string name, string country) : this(name)
        {
            CountryName = country;
        }
        public City(string name, string country, string code) : this(name, country)
        {
            PhoneCode = code;
        }
        public City(string name, string country, string code, List<string> districts) : this(name, country, code)
        {
            CityDistricts = districts;
        }
        public City(string name, string country, string code, List<string> districts, int population) : this(name, country, code, districts)
        {
            Population = population;
        }
        public string? this[int index]
        {
            get
            {
                if (index >= 0 && index < CityDistricts.Count)
                {
                    return CityDistricts[index];
                }
                else
                {
                    return null;
                }
            }
            set
            {
                if (index >= 0 && index < CityDistricts.Count && value != null)
                {
                    CityDistricts[index] = value;
                }
            }
        }
        public static City operator + (City city, int pop)
        {
            city.Population += pop;
            return city;
        }
        public static City operator -(City city, int pop)
        {
            city.Population -= pop;
            return city;
        }
        public static bool operator ==(City city1, City city2)
        {
            return city1.CityName == city2.CityName;
        }
        public static bool operator <(City city1, City city2)
        {
            return city1.Population < city2.Population;
        }
        public static bool operator >(City city1, City city2)
        {
            return city1.Population > city2.Population;
        }
        public static bool operator !=(City city1, City city2)
        {
            return city1.CityName != city2.CityName;
        }
        public override bool Equals(object? obj)
        {
            if (obj is City city)
            {
                return this.Population == city.Population;
            }
            return false;
        }
        public override int GetHashCode()
        {
            return this.Population.GetHashCode();
        }
        public void PrintInfo()
        {
            Console.WriteLine("City Name: " + CityName);
            Console.WriteLine("Country Name: " + CountryName);
            Console.WriteLine("Phone Code: " + PhoneCode);
            Console.WriteLine("City Districts: ");
            foreach (string district in CityDistricts)
            {
                Console.WriteLine(district);
            }
            Console.WriteLine("Population: " + Population);
        }
    }
}
