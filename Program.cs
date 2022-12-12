using Magazine;
using System;
using System.Diagnostics;
using Newtonsoft.Json;
using System.IO;

namespace Magazine
{
    public class Program
    {

        static void Main(string[] argrs)
        {
            List<ModelOfWorker> con;

            using (StreamReader read = new StreamReader("C:\\Users\\Overkliker\\source\\repos\\Magazine\\usersData.json"))
            {
                string a = read.ReadToEnd();
                con = JsonConvert.DeserializeObject<List<ModelOfWorker>>(a);

            }

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
                    Admin admin =  new Admin(worker);
                    admin.Interface();
                    break;
            }

        }
    }
}