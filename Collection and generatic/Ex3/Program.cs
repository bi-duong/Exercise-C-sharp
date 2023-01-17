namespace Ex3
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
            Console.WriteLine("5. Exit");
            Console.WriteLine("----------End----------");
            int i = 0;
            do
            {
                Console.Write("Your choice ========>  ");
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
                        break;
                    default:
                        Console.WriteLine("Please input in range 1-5!!!");
                        break;
                }
            }
            while (i != 5);
            Console.ReadKey();
        }
    }
}