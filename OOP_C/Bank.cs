
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

       public  void Snuatie(decimal howMuch)
        {
            if (howMuch <= Balans && howMuch > 0)
            {
                Balans -= howMuch;
            }
        }


        public void Popolnit(decimal howMuch)
        {
            if (howMuch > 0)
            {
                Balans += howMuch;
            }
        }

        static void Main(string[] args)
        {
          
            Bank bank1 = new Bank("ы", 80000000, CheckType.Savings);
            Console.WriteLine(bank1);
            Bank bank2 = new Bank(CheckType.Current);
            Console.WriteLine(bank2);
            Bank bank3 = new Bank(25000000);
            Console.WriteLine(bank3);
           

            Console.WriteLine("============================================================");
            Console.WriteLine("введите номер счета");
            string a = Console.ReadLine();
            

            Bank bank = null;

            switch (a){
                case "1": bank = bank1;
                    break;
                case "2": bank = bank2;
                    break;
                case"3": bank = bank3;
                    break;

            }
            Console.Clear();    
            Console.WriteLine(bank);
            if (bank == null)
            {
                Console.WriteLine("номер счета некорректен");
                Console.ReadLine();
                return;
            }
            Console.Clear();
            Console.WriteLine("Введите сумму");
            string c = Console.ReadLine();
            decimal sum = Convert.ToDecimal(c);


            Console.Clear();
            Console.WriteLine("Выберете операцию:\n1 - пополнить счет\n2 - снять деньги");
            string b = Console.ReadLine();
            switch (b)
            {
                case "1": bank.Popolnit(sum);
                    break;
                case "2": bank.Snuatie(sum);
                    break;
            }


            Console.WriteLine(bank);
            Console.ReadLine();
        }

    }
}
