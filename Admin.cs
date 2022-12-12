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
