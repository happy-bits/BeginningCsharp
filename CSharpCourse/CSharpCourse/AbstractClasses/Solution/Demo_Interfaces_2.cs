/* Interfaces fortsättning
 * Det tillkommer fler klasser:
 * - DvdMovie
 * - PaperPlane
 * 
 * Fördel:
 * - Klasserna får precis de interface de behöver och vi kan med lätthet skapa nya metoder som 
 *     FoldAll
 *     GetDescriptions
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpCourse.AbstractClasses.Solution
{
    public class Demo_Interfaces_2
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

        class DvdMovie : IDescribable
        {
            public string Describe() => $"I'm a DVD movie";
        }

        class PaperPlane : IFoldable, IDescribable
        {
            public void Fold()
            {
                IsReadyToFly = true;
            }

            public bool IsReadyToFly { get; private set; } = false;

            public string Describe() => $"I'm paper plane";
        }

        public static void Run()
        {
            var book = new Book();
            book.NextPage();
            book.NextPage();
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

            // Nytt

            var dvd = new DvdMovie();
            var paperplane = new PaperPlane();
            var items2 = new List<IFoldable> { newspaper, paperplane };
            var items3 = new List<IDescribable> { book, newspaper, dvd, paperplane };

            FoldAll(items2);

            if (paperplane.IsReadyToFly)
                Console.WriteLine($"5) Paper plane is ready to fly");

            string description = GetDescriptions(items3);
            Console.WriteLine();
            Console.WriteLine(description);

        }

        private static string GetDescriptions(List<IDescribable> items)
        {
            var sb = new StringBuilder();
            sb.AppendLine("Description:");
            foreach (IDescribable item in items)
            {
                sb.AppendLine($"* {item.Describe()}");
            }
            return sb.ToString();

        }

        private static void FoldAll(List<IFoldable> items)
        {
            foreach (IFoldable item in items)
            {
                item.Fold();
            }
        }

        private static void TwoPagesForward(List<IBrowsable> items)
        {
            foreach (IBrowsable item in items)
            {
                item.NextPage();
                item.NextPage();
            }
        }

    }
}
