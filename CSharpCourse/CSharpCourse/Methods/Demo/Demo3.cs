using System;

namespace CSharpCourse.Methods.Demo
{
    public class Demo3
    {
        public static void Run()
        {
            TimeSpan start = AskForTime("When did you start working in the morning?", TimeSpan.Zero);
            TimeSpan lunch = AskForTime("When did you go for lunch?", start);
            TimeSpan lunchEnd = AskForTime("When did your lunch end?", lunch);
            TimeSpan end = AskForTime("When did you go home from work?", lunchEnd);

            ReportWorkingHours(start, lunch, lunchEnd, end);
        }

        private static void ReportWorkingHours(TimeSpan start, TimeSpan lunch, TimeSpan lunchEnd, TimeSpan end)
        {
            var workTime = (lunch - start) + (end - lunchEnd);
            Console.WriteLine();

            Console.WriteLine($"You have worked {workTime.Hours}h and {workTime.Minutes} minutes");

        }

        private static TimeSpan AskForTime(string question, TimeSpan minimumTime)
        {
            while (true)
            {
                Console.Write(question + " ");
                string answer = Console.ReadLine();

                TimeSpan enteredTime;

                // booltips: påstående, och börja med "is" eller "has"

                bool hasCorrectFormat = TimeSpan.TryParse(answer, out enteredTime);

                if (hasCorrectFormat && enteredTime > minimumTime)
                {
                    return enteredTime;
                }
            }
        }
    }
}
