using System.Collections.Generic;

namespace CSharpCourse.Collections.Demo
{
    public class Demo1
    {
        // Shift-Ctrl-F12  => gå till nästa fel

        public static void Run()
        {
            //var fishes = new List<string>();
            //fishes.Add("Makrill");
            //fishes.Add("Torsk");
            //fishes.Add("Sill");
            //fishes.Add("Lax");

            // Alt-Enter
            // Collection initialization

            
            var fishes = new List<string>
            {
                "Makrill",  // 0
                "Torsk",    // 1
                "Sill",     // 2
                "Lax"       // 3
            };

            var nrOfFishes = fishes.Count; // 4

            var firstFish = fishes[0]; // "Makrill"
            var thirdFish = fishes[2]; // "Sill"

            fishes.Add("Rödspätta");

            // En lista av heltal

            var importantYears = new List<int>
            {
                570,
                1492,
                1789
            };

            importantYears.Add(1917);
            
            // En array av heltal

            var importantYears_Array = new int[]
            {
                570,
                1492,
                1789
            };

            var minaÅr = importantYears_Array.Length;  // 3
            //minaÅr.Add(123); // går ej

            // En hashset med tre värden

            var importantYears_hash = new HashSet<int> { 570, 1492, 1789 };
            var x1 = importantYears_hash.Count; // 3
            importantYears_hash.Add(1815);
            importantYears_hash.Add(1815);
            importantYears_hash.Add(1815);
            importantYears_hash.Add(1492);
            importantYears_hash.Add(1815);
            importantYears_hash.Add(1815);

            var x2 = importantYears_hash.Count; // 4 (antalet unika element)

            bool theYear1789Exists = importantYears_hash.Contains(1789); // true


        }
    }
}
