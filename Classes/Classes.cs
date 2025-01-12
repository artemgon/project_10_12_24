
namespace project_10_12_24.Classes
{
    internal class CreditCard
    {
        public string CardNumber { get; set; }
        public string SNP { get; set; }
        public string ExpiryDate { get; set; }
        public string CardType { get; set; }
        public float Money { get; set; }
        private string CVV;
        private string Password;
        public string CVV1
        {
            private get { return CVV; }
            set { CVV = value; }
        }
        public string Password1
        {
            private get { return Password; }
            set { Password = value; }
        }
        public CreditCard()
        {
            CardNumber = "0000 0000 0000 0000";
            SNP = "John Doe";
            ExpiryDate = "00/00";
            CardType = "Visa";
            CVV = "000";
            Password = "password";
            Money = 0;
        }
        public CreditCard(string number) : this()
        {
            CardNumber = number;
        }
        public CreditCard(string number, string sNP) : this(number)
        {
            SNP = sNP;
        }
        public CreditCard(string number, string sNP, string expiryDate) : this(number, sNP)
        {
            ExpiryDate = expiryDate;
        }
        public CreditCard(string number, string sNP, string expiryDate, string cardType) : this(number, sNP, expiryDate)
        {
            CardType = cardType;
        }
        public CreditCard(string number, string sNP, string expiryDate, string cardType, string cVV) : this(number, sNP, expiryDate, cardType)
        {
            CVV = cVV;
        }
        public CreditCard(string number, string sNP, string expiryDate, string cardType, string cVV, string password) : this(number, sNP, expiryDate, cardType, cVV)
        {
            Password = password;
        }
        public CreditCard(string number, string sNP, string expiryDate, string cardType, string cVV, string password, float money) : this(number, sNP, expiryDate, cardType, cVV, password)
        {
            Money = money;
        }
        public static CreditCard operator +(CreditCard card1, float sum)
        {
            card1.Money += sum;
            return card1;
        }
        public static CreditCard operator -(CreditCard card1, float sum)
        {
            card1.Money -= sum;
            return card1;
        }
        public static bool operator ==(CreditCard card1, CreditCard card2)
        {
            return card1.CVV == card2.CVV;
        }
        public static bool operator <(CreditCard card1, CreditCard card2)
        {
            return card1.Money < card2.Money;
        }
        public static bool operator >(CreditCard card1, CreditCard card2)
        {
            return card1.Money > card2.Money;
        }
        public static bool operator !=(CreditCard card1, CreditCard card2)
        {
            return card1.CVV != card2.CVV;
        }
        public override bool Equals(object? obj)
        {
            if (obj is CreditCard card)
            {
                return this.Money == card.Money;
            }
            return false;
        }
        public override int GetHashCode()
        {
            return this.Money.GetHashCode();
        }
        public void Display()
        {
            Console.WriteLine();
            Console.WriteLine("Credit Card Information: ");
            Console.WriteLine($"Card Number: {CardNumber}");
            Console.WriteLine($"SNP: {SNP}");
            Console.WriteLine($"Expiry Date: {ExpiryDate}");
            Console.WriteLine($"Card Type: {CardType}");
            Console.WriteLine($"CVV: {CVV}");
            Console.WriteLine();
        }
    }
}
