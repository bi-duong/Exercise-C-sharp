using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    class Book : IBook, IComparable<Book>
    {
        private string isbn, title, author, publisher;
        private int year;
        private ArrayList chapter = new ArrayList();
        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < chapter.Count)
                    return (String)chapter[index];
                else
                    throw new IndexOutOfRangeException();
            }
            set
            {
                if (index >= 0 && index < chapter.Count)
                    chapter[index] = value;
                else if (index == chapter.Count)
                    chapter.Add(value);
                else
                    throw new IndexOutOfRangeException();
            }
        }



        public int Year
        {
            get
            {
                if (year > 0)
                    return year;
                else
                    throw new Exception();
            }
            set
            {
                if (year > 0)
                    year = value;
                else
                    throw new Exception();
            }
        }

        public string ISBN { get => isbn; set => isbn = value; }
        public string Title { get => title; set => title = value; }
        public string Author { get => author; set => author = value; }
        public string Publisher { get => publisher; set => publisher = value; }

        public void Show()
        {
            Console.WriteLine("================================");
            Console.WriteLine("Title: " + Title);
            Console.WriteLine("Author: " + Author);
            Console.WriteLine("Publisher: " + Publisher);
            Console.WriteLine("Year: " + year);
            Console.WriteLine("ISBN: " + ISBN);
            Console.WriteLine("Chapter: ");
            for (int i = 0; i < chapter.Count; i++)
                Console.WriteLine("\t{0}: {1}", i + 1, chapter[i]);
            Console.WriteLine("================================");
        }
        

        public void Input()
        {
            Console.Write("Title: ");
            Title = Console.ReadLine();
            Console.Write("Author: ");
            Author = Console.ReadLine();
            Console.Write("Publisher: ");
            Publisher = Console.ReadLine();
            Console.Write("Year: ");
            year = int.Parse(Console.ReadLine());
            Console.Write("ISBN: ");
            ISBN = Console.ReadLine();
            Console.WriteLine("Input chapter (finished with empty string): ");
            string str;
            do
            {
                str = Console.ReadLine();
                if (str.Length > 0)
                {
                    chapter.Add(str);
                }
            } while (str.Length > 0);
        }

        public int CompareTo(Book other)
        {
            return this.title.CompareTo(other.title);
        }

    }
}
