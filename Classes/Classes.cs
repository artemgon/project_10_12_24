
namespace project_10_12_24.Classes
{
    public class Employee
    {
        public string SNP { get; set; }
        public string DateOfBirth { get; set; }
        public string PhoneNumber { private get; set; }
        public string WorkEmail { private get; set; }
        public string Position { private get; set; }
        public string Duties { private get; set; }
        public int Salary { private get; set; } 
        public Employee()
        {
            SNP = "Unknown";
            DateOfBirth = "Unknown";
            PhoneNumber = "Unknown";
            WorkEmail = "Unknown";
            Position = "Unknown";
            Duties = "Unknown";
            Salary = 0;
        }
        public Employee(string snp) : this()
        {
            SNP = snp;
        }
        public Employee(string snp, string dateOfBirth) : this(snp)
        {
            DateOfBirth = dateOfBirth;
        }
        public Employee(string snp, string dateOfBirth, string phoneNumber) : this(snp, dateOfBirth)
        {
            PhoneNumber = phoneNumber;
        }
        public Employee(string snp, string dateOfBirth, string phoneNumber, string workEmail) : this(snp, dateOfBirth, phoneNumber)
        {
            WorkEmail = workEmail;
        }
        public Employee(string snp, string dateOfBirth, string phoneNumber, string workEmail, string position) : this(snp, dateOfBirth, phoneNumber, workEmail)
        {
            Position = position;
        }
        public Employee(string snp, string dateOfBirth, string phoneNumber, string workEmail, string position, string duties) : this(snp, dateOfBirth, phoneNumber, workEmail, position)
        {
            Duties = duties;
        }
        public Employee(string snp, string dateOfBirth, string phoneNumber, string workEmail, string position, string duties, int salary) : this(snp, dateOfBirth, phoneNumber, workEmail, position, duties)
        {
            Salary = salary;
        }
        public static Employee operator +(Employee employee, int sum)
        {
            employee.Salary += sum;
            return employee;
        }
        public static Employee operator -(Employee employee, int sum)
        {
            employee.Salary -= sum;
            return employee;
        }
        public static bool operator ==(Employee employee1, Employee employee2)
        {
            return employee1.SNP == employee2.SNP;
        }
        public static bool operator <(Employee employee1, Employee employee2)
        {
            return employee1.Salary < employee2.Salary;
        }
        public static bool operator >(Employee employee1, Employee employee2)
        {
            return employee1.Salary > employee2.Salary;
        }
        public static bool operator !=(Employee employee1, Employee employee2)
        {
            return employee1.SNP != employee2.SNP;
        }
        public override bool Equals(object? obj)
        {
            if (obj is Employee employee)
            {
                return this.Salary == employee.Salary;
            }
            return false;
        }
        public override int GetHashCode()
        {
            return Salary.GetHashCode();
        }
        public void ShowInfo()
        {
            Console.WriteLine();
            Console.WriteLine("Employee info:");
            Console.WriteLine($"SNP: {SNP}");
            Console.WriteLine($"Date of birth: {DateOfBirth}");
            Console.WriteLine($"Phone number: {PhoneNumber}");
            Console.WriteLine($"Work email: {WorkEmail}");
            Console.WriteLine($"Position: {Position}");
            Console.WriteLine($"Duties: {Duties}");
            Console.WriteLine($"Salary: {Salary}");
            Console.WriteLine();
        }
        public void UpdateInfo(string phoneNumber, string workEmail, string position, string duties, int salary)
        {
            PhoneNumber = phoneNumber;
            WorkEmail = workEmail;
            Position = position;
            Duties = duties;
            Salary = salary;
        }
    }
}
