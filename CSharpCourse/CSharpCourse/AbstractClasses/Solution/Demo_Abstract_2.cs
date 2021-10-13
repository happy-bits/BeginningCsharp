/* Fortsättning på Abstrakta klasser 

Biblioteken hyr nu ut även DVD'er. Så en utvecklare tar fram klassen DvdMovie. 
Det är såklart ett LibraryItem

Problem:
- Eftersom LibraryItem inte var så genomtänkt så kommer DVD'n automatiskt få egenskapen att ha en "nuvarande sida" och metoden "NextPage". Ej bra.

 */
using System;
using System.Collections.Generic;

namespace CSharpCourse.AbstractClasses.Solution
{
    public class Demo_Abstract_2
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

        class Book : LibraryItem
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

        class DvdMovie : LibraryItem
        {
            public override string Describe() => $"I'm a DVD movie";
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

            var items = new List<LibraryItem> { book, newspaper };

            TwoPagesForward(items);

            Console.WriteLine($"3) {book.Describe()}");
            Console.WriteLine($"4) {newspaper.Describe()}");

            var dvd = new DvdMovie();

            dvd.NextPage(); // problem: vad betyder detta för en DVD-film?


        }

        private static void TwoPagesForward(List<LibraryItem> items)
        {
            foreach (var item in items)
            {
                item.NextPage();
                item.NextPage();
            }
        }
    }
}
