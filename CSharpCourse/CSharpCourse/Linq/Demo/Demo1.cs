

using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpCourse.Linq.Demo
{
    public class Demo1
    {
        public static void Run()
        {
            var list = new List<int> { 3, 10, 7 };

            Header("Listan:");
            Display("list", list);

            // Utan LINQ
            IEnumerable<int> numberHigherThanFive = NumberHigherThanFive(list);
            Header("Utan linq:");
            Display("numberHigherThanFive", numberHigherThanFive);

            // Med LINQ
            IEnumerable<int> numberHigherThanFive_Linq = NumberHigherThanFive_Linq(list);
            Header("Med linq:");
            Display("numberHigherThanFive_Linq", numberHigherThanFive_Linq);

            // Utan LINQ
            IEnumerable<string> starslist = StarifyList(list);
            Header("Utan linq:");
            Display("starslist", starslist);

            // Med LINQ
            IEnumerable<string> starslist_Linq = StarifyList_Linq(list);
            Header("Med linq:");
            Display("starslist_Linq", starslist_Linq);


            // Bonus

            var bonus = list
                .Where(i => i > 5)
                .Select(i => $"*{i}*");

            var sumAllNumbersGreaterThanFive = list.Where(i => i > 5).Sum();
            var averageOfAllNumbersGreaterThanTwo = list.Where(i => i > 2).Average();

            Header("Bonus");
            Display("bonus", bonus);
            Display("sumAllNumbersGreaterThanFive", sumAllNumbersGreaterThanFive);
            Display("averageOfAllNumbersGreaterThanTwo", averageOfAllNumbersGreaterThanTwo);
        }

        private static IEnumerable<string> StarifyList_Linq(List<int> list)
        {
            return list.Select(i => $"*{i}*");
        }

        private static IEnumerable<string> StarifyList(List<int> list)
        {
            var result = new List<string>();
            foreach (int i in list)
            {
                result.Add($"*{i}*");
            }
            return result;
        }

        private static IEnumerable<int> NumberHigherThanFive_Linq(IEnumerable<int> list)
        {
            return list.Where(i => i > 5);
        }

        private static IEnumerable<int> NumberHigherThanFive(IEnumerable<int> list)
        {
            var result = new List<int>();
            foreach (var i in list)
            {
                if (i > 5)
                    result.Add(i);
            }
            return result;
        }

        private static void Header(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.WriteLine(message.ToUpper());
            Console.WriteLine();
        }

        private static void Display(string text, IEnumerable<int> list)
        {
            Display(text, string.Join(",", list));
        }

        private static void Display(string text, IEnumerable<string> list)
        {
            Display(text, string.Join(",", list));
        }

        private static void Display(string text, object o)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"{text} = {o}");
        }

    }
}
