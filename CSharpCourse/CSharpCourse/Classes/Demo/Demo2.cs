using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourse.Classes.Demo
{
    public class Demo2
    {
        class Car
        {
            private string _color;
            private int _weight;

            public Car()
            {
                _color = "PINK";
            }

            public void SetColor(string color)
            {
                _color = color.Trim().ToUpper();
            }

            public string GetColor()
            {
                if (_color == null)
                {
                    return "UNKNOWN";
                }
                else
                {
                    return _color;
                }
            }

            public void SetWeight(int weight)
            {
                _weight = weight;
            }

            public int GetWeight()
            {
                return _weight;
            }
        }

        public static void Run()
        {
            var c1 = new Car();
            c1.SetColor("  bLue   ");
            c1.SetWeight(1200);
            Console.WriteLine($"The color of car1 is {c1.GetColor()} and the weight is {c1.GetWeight()}");

            var c2 = new Car();
            var c3 = new Car();

            c2.SetColor("Red");
            c2.SetWeight(800);

            Console.WriteLine($"The color of car2 is {c2.GetColor()} and the weight is {c2.GetWeight()}");
            Console.WriteLine($"The color of car3 is {c3.GetColor()} and the weight is {c3.GetWeight()}");

        }
    }
}
