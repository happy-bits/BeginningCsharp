using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourse.Inheritance.Demo
{
    public class Demo1
    {
        class Animal
        {
            public string Name { get; set; }
            public decimal Weight { get; set; }
        }

        enum FurSize
        {
            Short, Long
        }

        class Mammal: Animal
        {
            public FurSize FurSize { get; set; }  // "long" "short"
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
            var m = new Mammal();
            m.NrOfTeeth = 5;

            //m.FurSize = "long";
            //m.FurSize = "lång";
            //m.FurSize = "  long ";
            //m.FurSize = "llong";

            //m.FurSize = 1; // long
            //m.FurSize = 2; // short
            //m.FurSize = 3; // ?

            m.FurSize = FurSize.Short;
            m.FurSize = FurSize.Long;

            m.Name = "Kalle Kanin";
            m.Weight = 123;
        }
    }
}
