using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    class TitleComparer : IComparer<Book>
    {
        public int Compare(Book x, Book y)
        {
            return x.Title.CompareTo(y.Title);
        }
    }

    class AuthorComparer : IComparer<Book>
    {
        public int Compare(Book x, Book y)
        {
            return x.Author.CompareTo(y.Author);
        }
    }

    class PublisherComparer : IComparer<Book>
    {
        public int Compare(Book x, Book y)
        {
            return x.Publisher.CompareTo(y.Publisher);
        }
    }

    class YearComparer : IComparer<Book>
    {
        public int Compare(Book x, Book y)
        {
            return x.Year.CompareTo(y.Year);
        }
    }

    class ISBNComparer : IComparer<Book>
    {
        public int Compare(Book x, Book y)
        {
            return x.ISBN.CompareTo(y.ISBN);
        }
    }
}
