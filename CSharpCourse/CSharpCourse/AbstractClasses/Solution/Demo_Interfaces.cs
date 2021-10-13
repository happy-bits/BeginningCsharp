using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourse.AbstractClasses.Solution
{
    public class Demo_Interfaces
    {
        interface IDescribable
        {
            public string Describe();
        }

        interface IBrowsable
        {
            public void NextPage();
        }

        interface IFoldable
        {
            public void Fold();
        }

        class Book : IBrowsable, IDescribable
        {
            private int _currentpage = 1;

            public void NextPage()
            {
                _currentpage++;
            }

            public string Describe() => $"Book current page = {_currentpage}";

        }

        class Newspaper : IBrowsable, IFoldable, IDescribable
        {
            private int _currentpage = 1;
            private bool _isopen = true;

            public void Fold()
            {
                _isopen = false;
            }

            public void NextPage()
            {
                _currentpage++;
            }
            public string Describe() => $"Newspaper {(_isopen ? "is open" : "is folded")} and current page = {_currentpage}";

        }

        public static void Run()
        {
            var book = new Book();
            book.NextPage();
            book.NextPage();
            // book.Fold(); går inte
            Console.WriteLine($"1) {book.Describe()}");

            var newspaper = new Newspaper();
            newspaper.NextPage();
            newspaper.NextPage();
            newspaper.NextPage();
            newspaper.Fold();
            Console.WriteLine($"2) {newspaper.Describe()}");

            var items = new List<IBrowsable> { book, newspaper };

            TwoPagesForward(items);

            Console.WriteLine($"3) {book.Describe()}");
            Console.WriteLine($"4) {newspaper.Describe()}");

        }

        private static void TwoPagesForward(List<IBrowsable> items)
        {
            foreach (var item in items)
            {
                item.NextPage();
                item.NextPage();
            }
        }
    }
}
