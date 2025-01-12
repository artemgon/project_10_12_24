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
                CreditCard card = new("1234 5678 1234 5678", "John Doe", "12/34", "Visa", "123", "password", 1000);
                CreditCard card1 = new("1234 5678 1234 5678", "John Doe", "12/34", "Visa", "123", "password", 1000);
                card.Display();
                card1.Display();
                card += 1000;
                card1 += 1000;
                card.Display();
                card1.Display();
                card -= 1000;
                card1 -= 1000;
                card.Display();
                card1.Display();
                Console.WriteLine(card == card1);
                Console.WriteLine(card != card1);
                Console.WriteLine(card > card1);
                Console.WriteLine(card < card1);
                Console.WriteLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
