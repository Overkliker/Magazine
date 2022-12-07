using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazine
{
    internal class Autorize
    {
        public static int user;

        public static void PasswordInput(string pass)
        {
            /*string password = pass, inpt = string.Empty;
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
            }*/
        }
        public static void AdminAut()
        {
            Console.WriteLine();
            string name= Console.ReadLine();
            string password = Console.ReadLine();

        }

        public static void AccountentAut()
        {

        }

        public static void ManagerAut()
        {

        }

        public static void WarehouseManagerAut()
        {

        }
        public static void SellerAut()
        {

        }
    }
}
