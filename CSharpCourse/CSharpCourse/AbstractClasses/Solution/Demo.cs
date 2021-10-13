/* Inga extra klasser eller interface
 * 
 * Fördel:
 * - Enkel kod
 * 
 * Nackdel:
 * - Kod upprepar sig (NextPage, _currentpage)
 * - TwoPagesForward blir klumpig och det går att skicka inte lite vad som till metoden
 */
using System;
using System.Collections.Generic;

namespace CSharpCourse.AbstractClasses.Solution
{
    public class Demo
    {
        // En Book och Newspaper liknar varandra mycket, förutom att du kan vika en Newspaper

        class Book
        {
            protected int _currentpage = 1;

            public void NextPage()
            {
                _currentpage++;
            }
            public string Describe() => $"Book current page = {_currentpage}";
        }

        class Newspaper
        {
            private bool _isopen = true;
            protected int _currentpage = 1;

            public void NextPage()
            {
                _currentpage++;
            }

            public void Fold()
            {
                _isopen = false;
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

            var items = new List<object> { book, newspaper };

            TwoPagesForward(items);

            Console.WriteLine($"3) {book.Describe()}");
            Console.WriteLine($"4) {newspaper.Describe()}");
        }

        private static void TwoPagesForward(List<object> items)
        {
            foreach(var item in items)
            {
                Newspaper n = item as Newspaper;
                Book b = item as Book;

                if (n != null)
                {
                    n.NextPage();
                    n.NextPage();
                }
                if (b != null)
                {
                    b.NextPage();
                    b.NextPage();
                }

            }
        }
    }
}
