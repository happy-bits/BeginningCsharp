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
    public class Demo_Abstract
    {
        abstract class LibraryItem
        {
            protected int _currentpage = 1;

            public void NextPage()
            {
                _currentpage++;
            }

            abstract public string Describe();
        }

        class Book: LibraryItem
        {
            public override string Describe() => $"Book current page = {_currentpage}";
        }

        class Newspaper : LibraryItem
        {
            private bool _isopen = true;

            public void Fold()
            {
                _isopen = false;
            }
            public override string Describe() => $"Newspaper {(_isopen ? "is open" : "is folded")} and current page = {_currentpage}";
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

        private static void TwoPagesForward(List<LibraryItem> items)
        {
            foreach(var item in items)
            {
                item.NextPage();
                item.NextPage();
            }
        }
    }
}
