using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    class BookList
    {
        private List<Book> list = new List<Book>();

        public void AddBook()
        {
            Book b = new Book();
            b.Input();
            list.Add(b);
        }

        public void ShowList()
        {
            foreach (Book b in list)
                b.Show();
        }

        public void InputList()
        {
            int n;
            Console.Write("Amount of books: ");
            n = int.Parse(Console.ReadLine());
            while (n > 0)
            {
                AddBook();
                n--;
            }
        }

        public void ShowSort()
        {
            Console.WriteLine("Original list");
            ShowList();
            Console.WriteLine("Sort by Title (use IComparable)");
            list.Sort();
            ShowList();
            Console.WriteLine("Sort use IComparer");
            Console.WriteLine("Sort by Title");
            list.Sort(new TitleComparer());
            ShowList();
            Console.WriteLine("Sort by Author");
            list.Sort(new AuthorComparer());
            ShowList();
            Console.WriteLine("Sort by Publisher");
            list.Sort(new PublisherComparer());
            ShowList();
            Console.WriteLine("Sort by ISBN");
            list.Sort(new ISBNComparer());
            ShowList();
            Console.WriteLine("Sort by year");
            list.Sort(new YearComparer());
            ShowList();
        }
    }
}
