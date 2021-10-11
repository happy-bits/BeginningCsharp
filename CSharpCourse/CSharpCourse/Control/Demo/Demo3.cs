using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourse.Control.Demo
{
    public class Demo3
    {
        // Ctrl -    Gå dit du var nyss
        public static void Run()
        {
            // Kommentera:   Ctrl K C
            // Avkommentera: Ctrl K U

            //var planet0 = "Mercury";
            //var planet1 = "Venus";
            //var planet2 = "Earth";

            //var planets = new string[4];
            //planets[0] = "Mercury";
            //planets[1] = "Venus";
            //planets[2] = "Earth";
            //planets[3] = "Mars";

            var planets = new[] { "Mercury", "Venus", "Earth", "Mars" };

            // foreach tab tab (code snippet)
            foreach (var planet in planets)
            {
                Console.WriteLine(planet);
            }

            var importantYears = new[] { 570, 1492, 1789, 1917 };

            foreach (var year in importantYears)
            {
                Console.WriteLine($"The year {year}");
            }

            // for tab tab (code snippet)
            for (int i = 10; i <= 20; i++)
            {
                if (i == 15)
                    continue;

                Console.WriteLine(i);
            }

        }
    }
}
