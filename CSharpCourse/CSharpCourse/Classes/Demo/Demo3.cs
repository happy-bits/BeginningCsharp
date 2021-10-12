// Syfte: Konstruktorer gör att det blir snabbare att skapa ett objekt med vissa egenskaper (+ att vi styr hur en bil får skapas) 

using System;

namespace CSharpCourse.Classes.Demo
{
    public class Demo3
    {
        class Car
        {
            private string _color;
            private int _weight;

            public Car()
            {
                _color = "pink";
                _weight = 999;
            }

            public Car(string x, int y)
            {
                _color = x;
                _weight = y;
            }

            public void SetColor(string x)
            {
                _color = x;
            }

            public string GetColor()
            {
                return _color;
            }

            public void SetWeight(int x)
            {
                _weight = x;
            }

            public int GetWeight()
            {
                return _weight;
            }
        }

        public static void Run()
        {
            var c1 = new Car("blue", 1200);

            // Create c2: a red car that weight 800
            // Create c3: a default car (pink car that weight 999)

            var c2 = new Car("red", 800);
            var c3 = new Car();

            Console.WriteLine($"The color of car1 is {c1.GetColor()} and the weight is {c1.GetWeight()}");
            Console.WriteLine($"The color of car2 is {c2.GetColor()} and the weight is {c2.GetWeight()}");
            Console.WriteLine($"The color of car3 is {c3.GetColor()} and the weight is {c3.GetWeight()}");

        }
    }
}
