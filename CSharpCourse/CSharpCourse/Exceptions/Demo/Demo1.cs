using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourse.Exceptions.Demo
{
    public class Demo1
    {
        public static void Run()
        {
            while (true)
            {
                try
                {
                    Console.Write("Ange en siffra: ");
                    decimal number = decimal.Parse(Console.ReadLine());
                    decimal division = 1 / number;
                    Console.WriteLine($"Ett delat med talet blir {division}");
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Du får inte dela med 0 !");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Fel i formatet");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("För stort eller för litet tal");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Något gick snett!");
                    Console.WriteLine(ex.Message);
                    Console.WriteLine(ex.StackTrace);
                }
            }
        }
    }
}
