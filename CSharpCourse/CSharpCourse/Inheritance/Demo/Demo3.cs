using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourse.Inheritance.Demo
{
    public class Demo3
    {
        abstract class Mammal
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public abstract double AgeInHumanYears();

            //public virtual double AgeInHumanYears()
            //{
            //    return Age * 3;
            //}

        }

        class Cat : Mammal
        {
            public string FavoriteFish { get; set; }
            public override double AgeInHumanYears()
            {
                return Age * 5;
            }
        }

        class Dog : Mammal
        {
            public int BarkLevel { get; set; }
            public override double AgeInHumanYears()
            {
                return Age * 7;
            }
        }

        public static void Run()
        {
        }

        private static void DisplayInfoAboutMammal(Mammal m)
        {
            Console.WriteLine($"{m.Name} is {m.Age} which in human years is {m.AgeInHumanYears()}");
        }

    }
}
