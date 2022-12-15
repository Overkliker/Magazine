using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazine
{
    internal class Admin : User
    {
        ModelOfWorker admin = new ModelOfWorker();
        List<ModelOfWorker> allUsers = new List<ModelOfWorker>();
        internal enum Post
        {
            F1 = ConsoleKey.F1
        }
        public Admin(ModelOfWorker worker, List<ModelOfWorker> allUsers)
        {
            admin = worker;
            this.allUsers = allUsers;
        }
        public void Interface()
        {
            while (true)
            {
                InterfaceForUsers.PrintInterface(admin);
                ConsoleKeyInfo key = Console.ReadKey();
                if (Console.ReadKey().Key == (ConsoleKey)Post.F1)
                {
                    Console.Clear();
                    Create();
                }
                Console.Clear();
            }
            



        }
        public void Create()
        {
            string startupPath = Directory.GetCurrentDirectory();
            int len = startupPath.Length - 17;
            string json = startupPath.Substring(0, len) + "\\UserTables.json";
            List<UserTable> con = Converter.Des<List<UserTable>>(json);

            Console.WriteLine("Введите логин");
            string login = Console.ReadLine();
            Console.WriteLine("Введите пароль польвателя");
            string password = Console.ReadLine();
            Console.WriteLine("Введите роль польвателя");
            int role = Convert.ToInt32(Console.ReadLine());

            int id = con[con.Count - 1].id + 1;

            UserTable newUser = new UserTable();
            newUser.id = id;
            newUser.login = login;
            newUser.password = password;
            newUser.role = role;

            con.Add(newUser);

            Console.WriteLine("Введите название файла");
            string filename = Console.ReadLine();
            Converter.Ser<List<UserTable>>(con, filename);

        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void Read()
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Search()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }

    }
}
