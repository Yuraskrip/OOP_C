
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
        private Bank(string accountNumber, decimal balans, CheckType type)
        {
            CheckNumber = accountNumber;
            Balans = balans;
            Type = type;
            
        }
        public string CheckNumber { get; set; }
        public decimal Balans { get; set; }
        public CheckType Type { get; set; }
       public override string ToString() => $"CheckNumber - {CheckNumber}, Balans - {Balans}, Type - {Type}";


        static void Main(string[] args)
        {
            Bank bank = new Bank("1", 80000000, CheckType.Savings);
            Console.WriteLine(bank);
            Console.ReadLine(); 
        }

    }
}
