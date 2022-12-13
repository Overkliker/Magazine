using Magazine;
using System;
using System.Diagnostics;
using Newtonsoft.Json;
using System.IO;

namespace Magazine
{
    public class Program
    {
        internal enum Post
        {
            F1 = ConsoleKey.F1
        }
        static void Main(string[] argrs)
        {
            Console.WriteLine("0- Админ");
            if(Console.ReadKey().Key == (ConsoleKey)Post.F1)
            {
                Console.WriteLine(Post.F1);
            }

            List<ModelOfWorker> con = Converter.Des<List<ModelOfWorker>>();
            List<(string, string)> logins = new List<(string, string)>();
            for (int i = 0; i < con.Count; i++)
            {
                logins.Add((con[i].name, con[i].password));
            }

            int ind = Autorize.Aut(logins);
            ModelOfWorker worker = con[ind];

            switch (worker.atribute)
            {
                case 1:
                    Console.Clear();
                    Admin admin = new Admin(worker);
                    admin.Interface();
                    break;
            }

        }
    }
}