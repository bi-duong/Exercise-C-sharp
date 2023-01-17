using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    class AccountList
    {
        private List<Account> list = new List<Account>();

        internal List<Account> List { get => list; set => list = value; }

        public void AddAccount()
        {
            Account b = new Account();
            b.Input();
            List.Add(b);
            Console.WriteLine("Add success!");
        }

        public void Report()
        {
            foreach (Account b in List)
                b.Show();
        }

        public void SaveFile()
        {
            Console.Write("Input file name to save: ");
            string filename = Console.ReadLine();
            try
            {
                FileStream output = new FileStream(filename, FileMode.CreateNew, FileAccess.Write);
                StreamWriter writer = new StreamWriter(output);
                foreach (Account acc in List)
                {
                    writer.WriteLine("{0},{1},{2},{3}", acc.Id, acc.FName, acc.LName, acc.Balance);
                }
                writer.Close();
                output.Close();
                Console.WriteLine("Save file success!");
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void LoadFile()
        {
            Console.Write("Input file name to load: ");
            string filename = Console.ReadLine();
            List.Clear();
            try
            {
                FileStream input = new FileStream(filename, FileMode.Open, FileAccess.Read);
                StreamReader reader = new StreamReader(input);
                string str;
                while ((str = reader.ReadLine()) != null)
                {
                    string[] ls = str.Split(',');
                    Account acc = new Account(ls[0], ls[1], ls[2], double.Parse(ls[3]));
                    List.Add(acc);
                }
                input.Close();
                reader.Close();
                Console.WriteLine("Load file success!");
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }

       
    }
}
