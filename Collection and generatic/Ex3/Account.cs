using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    class Account
    {

        #region định nghĩa dữ liệu
        private string id, fName, lName;
        private double balance;

        public Account()
        {
        }

        public Account(string id, string fName, string lName, double balance)
        {
            Balance = balance;
            Id = id;
            FName = fName;
            LName = lName;
        }
        #endregion

        public double Balance
        {
            get
            {
                if (balance >= 0)
                    return balance;
                else
                    throw new Exception();
            }
            set
            {
                if (balance >= 0)
                    balance = value;
                else
                    throw new Exception();
            }
        }

        public string Id { get => id; set => id = value; }
        public string FName { get => fName; set => fName = value; }
        public string LName { get => lName; set => lName = value; }

        public void Show()
        {
            Console.WriteLine("==============================");
            Console.WriteLine("ID: " + Id);
            Console.WriteLine("First Name: " + FName);
            Console.WriteLine("Last Name: " + LName);
            Console.WriteLine("Balance: " + Balance);
            Console.WriteLine("==============================");
        }


        public void Input()
        {
            Console.Write("ID: ");
            Id = Console.ReadLine();
            Console.Write("First Name: ");
            FName = Console.ReadLine();
            Console.Write("Last Name: ");
            LName = Console.ReadLine();
            Console.Write("Balance: ");
            Balance = double.Parse(Console.ReadLine());
        }
    }
}
