
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
            CheckNumber = GetNextId().ToString();
            Balans = balans;
            Type = type;
            
        }

        private Bank(decimal balans)
        {
            CheckNumber = GetNextId().ToString();
            Balans = balans;

        }

        private Bank( CheckType type)
        {
            CheckNumber = GetNextId().ToString();
            Type = type;

        }



        public string CheckNumber;
        public decimal Balans;
        public CheckType Type;


        public static int number = 1;
        /// <summary>
        /// Увеличение значения переменной
        /// </summary>
        /// <returns></returns>
        public int GetNextId()
        {
            return number++;
        }

       
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
