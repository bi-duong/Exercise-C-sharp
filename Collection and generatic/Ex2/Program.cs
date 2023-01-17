using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BookList bl = new BookList();
            bl.InputList();
            bl.ShowSort();
            Console.ReadKey();
        }
    }
}