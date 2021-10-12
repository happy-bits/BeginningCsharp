using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ConsoleUtilities; // <--- nytt

namespace CSharpCourse.Collections.Demo
{
    public class Demo3
    {
        public static void Run()
        {
            var cc = new ConsoleCompanion();

            var heltal = cc.AskForInteger("Ange ett tal: ");

            var namn = cc.AskForString("Ange ditt namn", "Pelle");
            
            Console.WriteLine($"Du angav {heltal}");
            Console.WriteLine($"Ditt namn är {namn}");


            Console.ReadKey();
        }
    }
}
