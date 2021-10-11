using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourse.Fundamentals.Demo
{
    public class Demo2
    {
        public static void Run()
        {
            Console.Write("Enter your height: ");
            var answer = Console.ReadLine();

            var height = decimal.Parse(answer);
            var meters = height / 100;

            //var response = "You are " + meters + "m long"; // 70's
            //var response = string.Format("You are {0}m long", meters); // 90's

            var response = $"You are {meters}m long"; // 10's

            Console.WriteLine(response);

        }
    }
}
