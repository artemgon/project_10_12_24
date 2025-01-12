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
                Employee employee = new("John Doe", "01.01.2000", "+1234567890", "@work.email", "Manager", "Manage", 1000);
                Employee employee1 = new("John Doe", "01.01.2000", "+1234567890", "@work.email", "Manager", "Manage", 2000);
                employee.ShowInfo();
                employee1.ShowInfo();
                int sum = 1000;
                employee += sum;
                employee1 -= sum;
                Console.WriteLine(employee == employee1);
                Console.WriteLine(employee != employee1);
                Console.WriteLine(employee > employee1);
                Console.WriteLine(employee < employee1);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
