using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Magazine.Admin;

namespace Magazine
{
    internal class Admin : User
    {
        ModelOfWorker admin = new ModelOfWorker();
        //Юзеры системы
        List<ModelOfWorker> allUsers = new List<ModelOfWorker>();
        internal enum Post
        {
            F1 = ConsoleKey.F1,
            F2 = ConsoleKey.F2,
            F3 = ConsoleKey.F3,
            Enter = ConsoleKey.Enter
        }
        public Admin(ModelOfWorker worker, List<ModelOfWorker> allUsers)
        {
            admin = worker;
            this.allUsers = allUsers;
        }
        public void Interface()
        {
            int pose = 2;
            int max = allUsers.Count() + 2;
            while (true)
            {

                InterfaceForUsers.PrintInterface(admin);
                Console.SetCursorPosition(0, pose);
                Console.WriteLine("->");
                ConsoleKeyInfo key = Console.ReadKey();
                if (Console.ReadKey().Key == (ConsoleKey)Post.F1)
                {
                    Console.Clear();
                    Create();
                }

                else if (Console.ReadKey().Key == (ConsoleKey)Post.F3)
                {
                    Console.Clear();
                    Delete();
                }
                else if (key.Key == ConsoleKey.UpArrow)
                {
                    if (pose <= 2)
                    {
                        pose += max - 1;
                    }
                    else
                    {
                        pose--;
                    }

                }
                else if (key.Key == ConsoleKey.DownArrow)
                {
                    if (pose >= max - 1)
                    {
                        pose -= max - 1;
                    }
                    else
                    {
                        pose++;
                    }

                }
                else if (key.Key == (ConsoleKey)Post.Enter)
                {

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
            //Усечение строки до файла с юзерами
            string startupPath = Directory.GetCurrentDirectory();
            int len = startupPath.Length - 17;
            string json = startupPath.Substring(0, len) + "\\UserTables.json";
            List<UserTable> con = Converter.Des<List<UserTable>>(json);
            List<int> ids = new List<int>();

            //Добавление в список айдишников юзеров
            foreach (UserTable user in con)
            {
                ids.Add(user.id);
            }
            

            Console.WriteLine("Введите id пользователя, которого хотите удалить");
            int id = Convert.ToInt32(Console.ReadLine());

            //Проверка на существующий айдишник
            if (ids.Contains(id))
            {
                UserTable user = con[ids.IndexOf(id)];
                con.Remove(user);

                Console.WriteLine("Введите название файла");
                string filename = Console.ReadLine();
                Converter.Ser<List<UserTable>>(con, filename);

            }
            else
            {
                Console.WriteLine("Такого пользователя нету, нажмите любую клавишу, что бы выйти");
                Console.ReadKey();
                Console.Clear();
            }


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
            //Короче, здесь надо переделать, что бы он по ентеру передавал айдишник юзера в метод, и работал с ним
            string startupPath = Directory.GetCurrentDirectory();
            int len = startupPath.Length - 17;
            string json = startupPath.Substring(0, len) + "\\UserTables.json";
            List<UserTable> con = Converter.Des<List<UserTable>>(json);
            List<int> ids = new List<int>();

            foreach (UserTable user in con)
            {
                ids.Add(user.id);
            }

            Console.WriteLine("Введите id пользователя, которого хотите удалить");
            int id = Convert.ToInt32(Console.ReadLine());



            if (ids.Contains(id))
            {
                Console.WriteLine("Введите новый логин");
                string login = Console.ReadLine();
                Console.WriteLine("Введите новый пароль польвателя");
                string password = Console.ReadLine();
                Console.WriteLine("Введите новую роль польвателя");
                int role = Convert.ToInt32(Console.ReadLine());

                UserTable user = con[ids.IndexOf(id)];
                con.Remove(user);
                user.login = login;
                user.password = password;
                user.role = role;

                con.Add(user);
                Console.WriteLine("Введите название файла");
                string filename = Console.ReadLine();
                Converter.Ser<List<UserTable>>(con, filename);

            }
            else
            {
                Console.WriteLine();
                Console.ReadKey();
                Console.Clear();
            }

        }

    }
}
