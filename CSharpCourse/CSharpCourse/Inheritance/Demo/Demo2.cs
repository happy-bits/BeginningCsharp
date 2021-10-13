// Purpose: shows that you can create list of a general class (Animal) 
//        : shows that is possible to take a general class (Animal) as a parameter to a method
using System.Collections.Generic;
using System;
using System.Linq;

namespace CSharpCourse.Inheritance.Demo
{
    public class Demo2
    {

        enum FurSize
        {
            Short, Long
        }

        class Animal
        {
            public string Name { get; set; }
            public decimal Weight { get; set; }
        }

        class Mammal : Animal
        {
            public FurSize FurSize { get; set; }
            public int NrOfTeeth { get; set; }
        }

        class Cat : Mammal
        {
            public string FavoriteFish { get; set; }
        }

        class Dog : Mammal
        {
            public int BarkLevel { get; set; }
        }

        public static void Run()
        {
            var jerboa = new Mammal();
            jerboa.Name = "Jerry";
            jerboa.Weight = 80;
            jerboa.NrOfTeeth = 2;

            var pluto = new Dog();
            pluto.Name = "Pluto";
            pluto.NrOfTeeth = 4;

            var musse = new Cat();
            musse.Name = "Musse";
            musse.NrOfTeeth = 3;
            musse.FavoriteFish = "Salmon";

            // Create a list of the three mammals above

            List<Mammal> mams = new List<Mammal>();
            mams.Add(jerboa);
            mams.Add(pluto);
            mams.Add(musse);

            // Create a method "CountNrOfTeeth" that counts teeth of a list of mammals
            int teeth = CountNrOfTeeth(mams);
            Console.WriteLine($"Total number of teeth: {teeth}");


        }

        private static int CountNrOfTeeth(List<Mammal> mams)
        {
            int teeth = 0;

            foreach (var m in mams)
            {
                teeth += m.NrOfTeeth;
            }

            return teeth;
        }

        // Extra: lös "CountNrOfTeeth" med "LINQ"
    }
}
