using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazine
{
    public class InterfaceForUsers
    {
        public static void PrintInterface(ModelOfWorker user)
        {
            Console.SetCursorPosition(50, 0);
            Console.WriteLine($"Добро пожаловать, {user.name}");
            Console.SetCursorPosition(85, 0);
            Console.WriteLine($"Роль: Admin");
            Console.WriteLine("______________________________________________________________________________________________________________________________________________");
            Console.SetCursorPosition(5, 2);
            Console.WriteLine($"ID {user.id}");
            Console.SetCursorPosition(5, 3);
            Console.WriteLine($"PASSWORD {user.password}");
            Console.SetCursorPosition(5, 4);
            Console.WriteLine($"POST {user.post}");

            Console.SetCursorPosition(85, 2);
            Console.WriteLine("|");

            Console.SetCursorPosition(85, 3);
            Console.WriteLine("|");

            Console.SetCursorPosition(85, 4);
            Console.WriteLine("|");

            Console.SetCursorPosition(85, 5);
            Console.WriteLine("|");

            Console.SetCursorPosition(85, 6);
            Console.WriteLine("|");

            Console.SetCursorPosition(85, 7);
            Console.WriteLine("|");

            Console.SetCursorPosition(85, 8);
            Console.WriteLine("|");

            Console.SetCursorPosition(85, 9);
            Console.WriteLine("|");

            Console.SetCursorPosition(85, 10);
            Console.WriteLine("|");

            Console.SetCursorPosition(95, 2);
            Console.WriteLine("F1 - добавить запись");
            Console.SetCursorPosition(95, 3);
            Console.WriteLine("F2 - найти запись");
        }
    }
}
