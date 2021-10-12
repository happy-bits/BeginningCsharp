using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourse.Classes.Demo
{
    public class Demo1
    {
        class Car
        {
            private string _color;

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
        }

        public static void Run()
        {
            var c1 = new Car();
            c1.SetColor("  bLue   ");
            Console.WriteLine($"The color of car1 is {c1.GetColor()}");

            var c2 = new Car();
            var c3 = new Car();

            c2.SetColor("Red");

            Console.WriteLine($"The color of car2 is {c2.GetColor()}");
            Console.WriteLine($"The color of car3 is {c3.GetColor()}");

        }
    }
}
