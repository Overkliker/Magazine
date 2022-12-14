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
            UsersForAdmin();

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

        public static void UsersForAdmin()
        {
            string startupPath = Directory.GetCurrentDirectory();
            string json = startupPath.Substring(0, 41) + "\\UserTables.json";
            List<UserTable> con = Converter.Des<List<UserTable>>(json);
            for (int i = 2; i < con.Count + 2; i++)
            {
                Console.SetCursorPosition(5, i);
                Console.WriteLine($"ID {con[i - 2].id}");
                Console.SetCursorPosition(15, i);
                Console.WriteLine($"{con[i - 2].login}");
                Console.SetCursorPosition(35, i);
                Console.WriteLine($"{con[i - 2].password}");
                Console.SetCursorPosition(60, i);
                Console.WriteLine($"{con[i - 2].role}");
            }

        }
    }
}
