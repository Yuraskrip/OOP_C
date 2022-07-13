
namespace OOP_C
{
    /// <summary>
    /// Работа со строками
    /// </summary>
    public class STR1
    {
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

        public static string St()
        {
            string st = "Кучма Андрей Витальевич & Kuchma @mail.ru Мизинцев Павел Николаевич & Pasha @mail.ru";
            Console.WriteLine(st);

            return (st);
        }
        /// <summary>
        /// Разделение текста
        /// </summary>
        /// <param name="st"></param>
        public void SearchMail(ref string st)
        {
            string[] email = st.Split(new char[] { '&' });

            for (int i = 0; i < email.Length; i++)
            {
                email[i] = email.Length.ToString();
                email = new string[email.Length];
                Console.WriteLine(email);
            }

        }




    }
}
