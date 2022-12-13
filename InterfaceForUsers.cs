using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazine
{
    public class InterfaceForUsers
    {
        public static string[] roles = new string[] { "Admin", "Manager", "Seller", };
        public static void PrintInterface(ModelOfWorker user)
        {
            Console.SetCursorPosition(50, 0);
            Console.WriteLine($"Добро пожаловать, {user.name}");
            Console.SetCursorPosition(85, 0);
            Console.WriteLine($"Роль: {roles[user.atribute]}");
            Console.WriteLine("______________________________________________________________________________________________________________________________________________");
            Console.SetCursorPosition(5, 2);
            Console.WriteLine($"ID {user.id}");
            Console.SetCursorPosition(5, 3);
            Console.WriteLine($"PASSWORD {user.password}");
            Console.SetCursorPosition(5, 4);
            Console.WriteLine($"POST {user.post}");

            for (int i = 2; i < 12; i++)
            {
                Console.SetCursorPosition(85, i);
                Console.WriteLine("|");
            }

            Console.SetCursorPosition(95, 2);
            Console.WriteLine("F1 - добавить запись");
            Console.SetCursorPosition(95, 3);
            Console.WriteLine("F2 - найти запись");
        }
    }
}
