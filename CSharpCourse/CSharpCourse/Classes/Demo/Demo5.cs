// Syfte: Alternativ lösning om vi inte vill färgen eller vikten på bilen ska ändras när bilen väl är skapad

using System;

namespace CSharpCourse.Classes.Demo
{
    public class Demo5
    {
        class Car
        {
            public int Weight { get; }    // <----- notera
            public string Color { get; }  // <----- notera

            public Car(string c, int w)
            {
                Color = c;
                Weight = w;
            }

            public Car()
            {
                Color = "pink";
                Weight = 999;
            }
        }

        public static void Run()
        {
            var c1 = new Car("blue", 1200);
            var c2 = new Car("red", 800);
            var c3 = new Car(); // ska ge en bil med lila färg som väger 999kg 

            //c2.Color = "yellow";    <------- nu funkar inte detta längre
            //c2.Weight = 600;        <------- nu funkar inte detta längre

            Console.WriteLine($"The color of car1 is {c1.Color} and the weight is {c1.Weight}");
            Console.WriteLine($"The color of car2 is {c2.Color} and the weight is {c2.Weight}");
            Console.WriteLine($"The color of car3 is {c3.Color} and the weight is {c3.Weight}");
        }
    }
}
