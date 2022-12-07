using System;
using System.Diagnostics;

namespace ScorePech
{
    public class Program
    {

        static void Main(string[] argrs)
        {
            while (true)
            {
                Console.WriteLine("Выберите под каким пользователем вы хотите зайти:\n" +
                    "1 - Администратор; 2 - Менеджер персонала; 3 - Склад-менеджер; 4 - Кассир; 5 - Бухгалтер");
                int userInSpase = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}