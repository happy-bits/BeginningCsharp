using System;
using System.IO;

namespace CSharpCourse.Interfaces.Solution
{
    public class Example02WithInterfaces
    {
        interface ILog
        {
            void Log(string message);
        }

        class ConsoleLogger: ILog
        {
            public void Log(string message)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(message);
            }
        }

        class FileLogger : ILog
        {
            public void Log(string message)
            {
                File.AppendAllLines(@"C:\TMP\loggfile.txt", new[] { message });
            }
        }

        class DetailedFileLogger : ILog
        {
            public void Log(string message)
            {
                File.AppendAllLines(@"C:\TMP\loggfile.txt", new[] { $"{DateTime.Now}\t{message}" });
            }
        }

        class KalleLogger : ILog
        {
            public void Log(string message)
            {
                throw new NotImplementedException();
            }
        }

        static void DivideTwoNumbers(ILog logger, decimal a, decimal b)
        {

            logger.Log("DivideTwoNumbers started!");
            logger.Log($"a={a} and b={b}");

            decimal result = a / b;

            logger.Log($"Result of calculation: {result}");
            logger.Log("DivideTwoNumbers finished!");
        }


        public static void Run()
        {
            string loggerchoice = File.ReadAllText(@"Interfaces\Solutions\loggerchoice.txt");

            switch (loggerchoice)
            {
                case "File":
                    DivideTwoNumbers(new FileLogger(), 4, 10);
                    break;
                case "Console":
                    DivideTwoNumbers(new ConsoleLogger(), 4, 10);
                    break;
                case "Detailed":
                    DivideTwoNumbers(new DetailedFileLogger(), 4, 10);
                    break;
                case "Kalle":
                    DivideTwoNumbers(new KalleLogger(), 4, 10);
                    break;
                default:
                    throw new Exception($"Okänd logger: {loggerchoice}");

            }

        }

    }
}
