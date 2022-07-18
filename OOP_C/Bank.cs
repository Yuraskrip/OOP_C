
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
    public class Bank
    {
        /// <summary>
        /// Создание класса объекта с закрытыми полями
        /// </summary>
        /// <param name="checkNumber">Номер счета</param>
        /// <param name="balans">Баланс</param>
        /// <param name="type">Тип банковского счета</param>
        public Bank(string checkNumber, decimal balans, CheckType type)
        {
            CheckNumber = Number.ToString();
            Balans = balans;
            Type = type;
            
        }

        public Bank(decimal balans)
        {
            CheckNumber = Number.ToString();
            Balans = balans;

        }

        public Bank( CheckType type)
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
       public  bool Snuatie(decimal howMuch)
        {
            if (howMuch <= Balans && howMuch > 0)
            {
                Balans -= howMuch;
                return true;

            }
            return false;
        }

        /// <summary>
        /// Пополнение счета
        /// </summary>
        /// <param name="howMuch"></param>
        public bool Popolnit(decimal howMuch)
        {
            if (howMuch > 0)
            {
                Balans += howMuch;
                return true;
            }
            return false;
        }
        /// <summary>
        /// Перевод 
        /// </summary>
        /// <param name="bank"></param>
        /// <param name="howMuch"></param>
        /// <returns></returns>
        public bool Perevod(ref Bank bank, decimal howMuch)
        {
            if(bank != null && howMuch > 0)
            {
                if(howMuch < bank.Balans)
                {
                    bank.Balans -= howMuch;
                    Balans += howMuch;
                    return true;
                }
            }
            return false;
        }

    }
}
