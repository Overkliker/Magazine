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
                Console.WriteLine("0- Админ");
                if (Console.ReadKey().Key == (ConsoleKey)Post.F1)
                {
                    Create();
                }
                Console.Clear();
            }
            



        }
        public void Create()
        {
            Console.WriteLine("Введите индекс пользователя которого хотите создать");
            Console.WriteLine("Введите пароль пользователя");
            Console.WriteLine("Введите имя польвателя");
            Console.WriteLine("Введите фамилию польвателя");

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
