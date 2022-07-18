
//1.В класс банковский счет, созданный в упражнениях, добавить метод, который переводит деньги с одного счета на другой.
//    У метода два параметра: ссылка на объект класса банковский счет откуда снимаются деньги, второй параметр – сумма.


//2.Реализовать метод, который в качестве входного параметра принимает строку string,
//    возвращает строку типа string, буквы в которой идут в обратном порядке. Протестировать метод.

//3. * Работа со строками.Дан текстовый файл, содержащий ФИО и e-mail адрес. 
//    Разделителем между ФИО и адресом электронной почты является символ &: 
//    Кучма Андрей Витальевич & Kuchma @mail.ru Мизинцев Павел Николаевич & Pasha @mail.ru
//    Сформировать новый файл, содержащий список адресов электронной почты.Предусмотреть метод, выделяющий из строки адрес почты.
//    Методу в качестве параметра передается символьная строка s, e-mail возвращается в той же строке s: public void SearchMail(ref string s).

using OOP_C;

public class Program
{
    public static void Main(string[] args)
    {

        Console.WriteLine("============================================================");
        Console.WriteLine("Для банковских операций нажмите 1\nДля реверса строки нажмите 2\nДля других операций со строками нажмите 3");
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
                    case "3":
                        bank.Perevod(ref bank, sum);
                        break;
                }
                Console.WriteLine(bank);
                Console.ReadLine();
                break;
            case "2":
                Console.Clear();
                Console.WriteLine("Введите строку");
                STR1.ReverseString(Console.ReadLine());
                break;
            case "3":
                STR1.SpisokEmail();
                break;
        }

    }
}

