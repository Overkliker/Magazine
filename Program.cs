using System;
using System.Diagnostics;

namespace ScorePech
{
    public class Program
    {

        static void Main(string[] argrs)
        {
            /*while (true)
            {
                Console.WriteLine("Выберите под каким пользователем вы хотите зайти:\n" +
                    "1 - Администратор; 2 - Менеджер персонала; 3 - Склад-менеджер; 4 - Кассир; 5 - Бухгалтер");
                int userInSpase = Convert.ToInt32(Console.ReadLine());
            }*/
            string password = "НИКИТА1257", inpt = string.Empty;
            while (password != inpt)
            {
                Console.Write("Введите пароль для работы с файлами Windows: ");
                inpt = string.Empty;
                while (true)
                {
                    var key = Console.ReadKey(true);//не отображаем клавишу - true

                    if (key.Key == ConsoleKey.Enter) break; //enter - выходим из цикла

                    Console.Write("*");//рисуем звезду вместо нее
                    inpt += key.KeyChar; //копим в пароль символы
                }
                Console.WriteLine();
            }
            Console.Write("Допуск получен!");
            Console.ReadKey();
        }
    }
}