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
        internal enum Post
        {
            F1 = ConsoleKey.F1
        }
        public Admin(ModelOfWorker worker)
        {
            admin = worker;
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
                    Console.WriteLine(Post.F1);
                }
                Console.Clear();
            }
            



        }
        public void Create()
        {
            throw new NotImplementedException();
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
