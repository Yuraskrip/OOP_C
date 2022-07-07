
namespace OOP_C
{

    /// <summary>
    /// Перечисляемый тип банковского счета
    /// </summary>
    enum CheckType
    {
        Current,
        Savings
    }
    internal class Bank
    {
        /// <summary>
        /// Создание класса объекта с закрытыми полями
        /// </summary>
        /// <param name="checkNumber">Номер счета</param>
        /// <param name="balans">Баланс</param>
        /// <param name="type">Тип банковского счета</param>
        private Bank(string checkNumber, decimal balans, CheckType type)
        {
            CheckNumber = number.ToString();
            Balans = balans;
            Type = type;
            
        }

        private Bank(decimal balans)
        {
            CheckNumber = number.ToString();
            Balans = balans;

        }

        private Bank( CheckType type)
        {
            CheckNumber = number.ToString();
            Type = type;

        }



        public string CheckNumber { get; set; }
        public decimal Balans { get; set; }
        public CheckType Type { get; set; }


        public static int number { get { return Num++; }  set { Num = value; } }
        private static int Num = 1;
       
        public override string ToString() => $"CheckNumber - {CheckNumber}, Balans - {Balans}, Type - {Type}";


        static void Main(string[] args)
        {
          
            Bank bank = new Bank("ы", 80000000, CheckType.Savings);
            Console.WriteLine(bank);
             bank = new Bank(CheckType.Current);
            Console.WriteLine(bank);
             bank = new Bank(25000000);
            Console.WriteLine(bank);
            Console.ReadLine(); 
        }

    }
}
