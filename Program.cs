using project_10_12_24.Classes;

namespace project_10_12_24
{
    internal class Program
    {
        static void Main()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            try
            {
                List<string> districts = [ "Manhattan", "Brooklyn", "Queens", "Bronx", "Staten Island" ];
                City city = new ("New York", "USA", "+1", districts , 8_336_817);
                //Console.WriteLine($"City: {city.City_Name}"); - city name is private, so inaccesible
                Console.WriteLine($"Country: {city.CountryName}");
                Console.WriteLine($"Phone code: {city.PhoneCode}");
                Console.WriteLine($"Population: {city.Population}");
                Console.WriteLine("Districts:");
                for (int i = 0; i < city.CityDistricts.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {city[i]}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
