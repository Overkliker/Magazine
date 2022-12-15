﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Magazine
{
    internal class Autorize
    {
        public static int user;

        public static (string, string, bool) PasswordInput(string name, List<(string, string)> workers)
        {

            //Ввод пароля, да не обычного, а типа пассворд бокса!
            string inpt = string.Empty;
            while (!workers.Contains((name, inpt)))
            {
                Console.Write("Введите пароль: ");
                inpt = string.Empty;
                while (true)
                {
                    var key = Console.ReadKey(true);//не отображаем клавишу - true

                    if (key.Key == ConsoleKey.Enter) break; //enter - выходим из цикла

                    Console.Write("*");//рисуем звезду вместо нее
                    inpt += key.KeyChar; //копим в пароль символы
                }
                
                if (!workers.Contains((name, inpt)))
                {
                    Console.WriteLine("Написал хуйню какую-то");
                    break;
                }
                Console.WriteLine();
            }
            if (!workers.Contains((name, inpt)))
            {
                return (name, inpt, false);
            }
            else
            {
                return (name, inpt, true);
            }

        }

        public static int Aut(List<(string, string)> workers)
        {
            while (true)
            {
                //Ввод логина юзера
                Console.WriteLine("Введите имя");
                string name= Console.ReadLine();

                var password = PasswordInput(name, workers);
                if (password.Item3 == false)
                {
                    return 0;

                }
                else
                {
                    return workers.IndexOf((password.Item1, password.Item2));
                }
            }
            

        }
    }
}
