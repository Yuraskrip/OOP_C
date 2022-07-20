using System.IO;

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
          if (s == null)
            {
                return null;
            }
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            Console.WriteLine(arr);
            Console.ReadLine();
            return new string(arr);

        }
      /// <summary>
      /// Разделение строки
      /// </summary>
      /// <param name="s"></param>
        public static void SearchMail(ref string s)
        {
            s = s.Split("&")[1];
        }
        /// <summary>
        /// Вывод списка e-mail в новый файл
        /// </summary>
        public static void SpisokEmail()
        {
            string stroka = "../../../../Email.txt";
            File.Delete(stroka);
            string[] lines = File.ReadAllLines("../../../../firstEmail.txt");
            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];
                SearchMail(ref line);
                File.AppendAllText(stroka, line.Trim() + "\n");
            }
            
        }


    }
}
