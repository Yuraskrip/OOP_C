
namespace OOP_C
{

    /// <summary>
    /// Перечисляемый тип банковского счета
    /// </summary>
    public enum CheckType
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
            CheckNumber = Number.ToString();
            Balans = balans;
            Type = type;
            
        }

        private Bank(decimal balans)
        {
            CheckNumber = Number.ToString();
            Balans = balans;

        }

        private Bank( CheckType type)
        {
            CheckNumber = Number.ToString();
            Type = type;

        }



        public string CheckNumber { get; set; }
        public decimal Balans { get; set; }
        public CheckType Type { get; set; }


        public static int Number { get { return Num++; }  set { Num = value; } }
        private static int Num = 1;
       
        public override string ToString() => $"CheckNumber - {CheckNumber}, Balans - {Balans}, Type - {Type}";

        /// <summary>
        /// Снятие со счета
        /// </summary>
        /// <param name="howMuch"></param>
       public  void Snuatie(decimal howMuch)
        {
            if (howMuch <= Balans && howMuch > 0)
            {
                Balans -= howMuch;
            }
        }

        /// <summary>
        /// Пополнение счета
        /// </summary>
        /// <param name="howMuch"></param>
        public void Popolnit(decimal howMuch)
        {
            if (howMuch > 0)
            {
                Balans += howMuch;
            }
        }
        /// <summary>
        /// Перевод денег
        /// </summary>
        /// <param name="bank">Выбранный банковский счет</param>
        /// <param name="howMuch"></param>
        /// <param name="sum"></param>
        /// <param name="bank1">Счет для перевода</param>
        /// <param name="bank2">Счет для перевода</param>
        /// <param name="bank3">Счет для перевода</param>
        public void Perevod(ref Bank bank, decimal howMuch, decimal sum , ref Bank bank1, ref Bank bank2, ref Bank bank3)
        {
            if (howMuch <= Balans && howMuch > 0)
            {
                Console.WriteLine("введите номер счета, куда перевести деньги");
                string b = Console.ReadLine();

               // Bank bank4 = null;

                switch (b)
                {
                    case "1":
                        bank.Snuatie(sum);
                        bank1.Popolnit(sum);
                        Console.WriteLine(bank);
                        Console.WriteLine(bank1);

                        break;
                    case "2":
                        bank.Snuatie(sum);
                        bank2.Popolnit(sum);
                        Console.WriteLine(bank);
                        Console.WriteLine(bank2);
                        break;
                    case "3":
                        bank.Snuatie(sum);
                        bank3.Popolnit(sum);
                        Console.WriteLine(bank);
                        Console.WriteLine(bank3);

                        break;

                }


            }
        }

        /// <summary>
        /// Реверс строки
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string ReverseString(string s)
        {
            Console.WriteLine("Введите строку");
            s = Console.ReadLine();

            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            Console.WriteLine(arr);
            Console.ReadLine();
            return new string(arr);
            
        }

        public static void Main(string[] args)
        {
           
            Console.WriteLine("============================================================");
            Console.WriteLine("Для банковских операций нажмите 1\nДля реверса строки нажмите 2");
            string d = Console.ReadLine();
            
            switch (d)
            {
                case "1":
                    Console.Clear();
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

                    switch (a)
                    {
                        case "1":
                            bank = bank1;
                            break;
                        case "2":
                            bank = bank2;
                            break;
                        case "3":
                            bank = bank3;
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
                    decimal sum = decimal.Parse(c);


                    Console.Clear();
                    Console.WriteLine("Выберете операцию:\n1 - пополнить счет\n2 - снять деньги\n3 - перевод денег");
                    string b = Console.ReadLine();
                    switch (b)
                    {
                        case "1":
                            bank.Popolnit(sum);
                            break;
                        case "2":
                            bank.Snuatie(sum);
                            break;
                            case "3": bank.Perevod(ref bank, sum, sum, ref bank1, ref bank2, ref bank3);
                            break;
                    }


                    Console.WriteLine(bank);
                    Console.ReadLine();


                    break;
                case "2":
                    Console.Clear();
                    ReverseString("s");
                    break;
            }


           


            
        }

    }
}
