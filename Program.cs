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

            string startupPath = Directory.GetCurrentDirectory();
            int len = startupPath.Length - 17;

            string json = startupPath.Substring(0, len) + "\\usersData.json";
            List<ModelOfWorker> con = Converter.Des<List<ModelOfWorker>>(json);














































            string jsonUs = startupPath.Substring(0, len) + "\\UserTables.json";
            List<UserTable> convert = Converter.Des<List<UserTable>>(jsonUs);

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
                    Admin admin = new Admin(worker, convert);
                    admin.Interface();
                    break;
            }

        }
    }
}