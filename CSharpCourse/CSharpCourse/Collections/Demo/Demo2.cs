// Usage of dictionaries. 

using System;
using System.Collections.Generic;

namespace CSharpCourse.Collections.Demo
{
    public class Demo2
    {
        public static void Run()
        {
            /*
             
            Bookstore 1:

                Pricecategory A costs 35kr
                Pricecategory B costs 45kr
                Pricecategory C costs 68kr
            
            Bookstore 2:

                Pricecategory A costs 35kr
                Pricecategory B costs 35kr
                Pricecategory C costs 77kr
             
            Bookstore 3:

                Pricecategory A costs 35kr
                Pricecategory A costs 45kr
                Pricecategory C costs 68kr

            We can't model Bookstore 3 because no one known how much a book with category A costs

             */

            var p = new Dictionary<char, int>();
            p.Add('A', 35);
            p.Add('B', 45);
            p.Add('C', 68);

            // Mer kompakt

            var prices = new Dictionary<char, int>
            {
                { 'A', 35 },
                { 'B', 45 },
                { 'C', 68 }
            };

            //Console.WriteLine($"The books in price category A costs {prices['A']}kr");
            //Console.WriteLine($"The books in price category B costs {prices['B']}kr");
            //Console.WriteLine($"The books in price category C costs {prices['C']}kr");

            foreach (var item in prices)
            {
                //  Exempel
                //  item.Key   --> 'B'
                //  item.Value --> 45
                Console.WriteLine($"The books in price category {item.Key} costs {item.Value}kr");

            }

            // prices.ContainsKey('B') --> true

            if (prices.ContainsKey('B'))
            {
                Console.WriteLine("Price category B exists");
            }

            if (prices.ContainsKey('D'))
            {
                Console.WriteLine("Price category D exists");
            }

            // Lägg till en priskategori
            prices.Add('D', 150);
            // prices.Add('D', 666); // <--- exception

            // Ta bort en
            prices.Remove('B');

            // Ändra ett pris
            prices['A'] = 20;

            Console.WriteLine();

            // Skriv ut de nya priserna

            foreach (var item in prices)
            {
                Console.WriteLine($"The books in price category {item.Key} costs {item.Value}kr");
            }
        }
    }
}
