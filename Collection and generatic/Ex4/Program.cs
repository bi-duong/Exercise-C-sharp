using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Ex4 
{
    internal class Program
    {

        static void Main(string[] args)
        {
            AccountList list = new AccountList();
            Console.WriteLine("----------MENU----------");
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Save");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Show List");
            Console.WriteLine("5. Remove");
            Console.WriteLine("6. Sort by ID");
            Console.WriteLine("7. Sort by First Name");
            Console.WriteLine("8. Sort by Balance");
            Console.WriteLine("9. Exit");
            Console.WriteLine("----------End----------");
            int i = 0;
            do
            {
                Console.Write("Your choice========>  ");
                i = int.Parse(Console.ReadLine());
                switch (i)
                {
                    case 1:
                        list.AddAccount();
                        break;
                    case 2:
                        list.SaveFile();
                        break;
                    case 3:
                        list.LoadFile();
                        break;
                    case 4:
                        list.Report();
                        break;
                    case 5:
                        Console.Write("Input ID to remove: ");
                        string s = Console.ReadLine();
                        list.Remove(s);
                        break;
                    case 6:
                        list.List.Sort(new IDComparer());
                        list.Report();
                        break;
                    case 7:
                        list.List.Sort(new FNameComparer());
                        list.Report();
                        break;
                    case 8:
                        list.List.Sort(new BalanceComparer());
                        list.Report();
                        break;
                    case 9:
                        break;
                    default:
                        Console.WriteLine("Please input in range 1-9!!!");
                        break;
                }
            }
            while (i != 9);
            Console.ReadKey();
        }
    }
}