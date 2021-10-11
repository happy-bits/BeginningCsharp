using System;

namespace CSharpCourse.Methods.Demo
{
    public class Demo2
    {
        public static void Run()
        {
            // Quick actions: Alt-Enter (eller Ctrl .)
            TimeSpan start = AskForTime("When did you start working in the morning?");
            TimeSpan lunch = AskForTime("When did you go for lunch?");
            TimeSpan lunchEnd = AskForTime("When did your lunch end?");
            TimeSpan end = AskForTime("When did you go home from work?");

            //Console.WriteLine($"Hours: {start.Hours}. Minutes: {start.Minutes}");

            ReportWorkingHours(start, lunch, lunchEnd, end);
        }

        private static void ReportWorkingHours(TimeSpan start, TimeSpan lunch, TimeSpan lunchEnd, TimeSpan end)
        {
            //var förmiddagsTid = lunch - start;
            //var eftermiddagsTid = end - lunchEnd;
            //var jobbTid = förmiddagsTid + eftermiddagsTid;

            var workTime = (lunch - start) + (end - lunchEnd);
            Console.WriteLine();

            Console.WriteLine($"You have worked {workTime.Hours}h and {workTime.Minutes} minutes");

        }

        private static TimeSpan AskForTime(string question)
        {
            Console.Write(question + " ");
            string answer = Console.ReadLine();
            TimeSpan time = TimeSpan.Parse(answer);
            return time;
        }
    }
}

// Markera + Alt piltangent => flyttar en kodmassa

//Console.Write("When did you go for lunch? ");
//string lunchString = Console.ReadLine();
//TimeSpan lunch = TimeSpan.Parse(lunchString);

//Console.Write("When did your lunch end? ");
//string lunchEndString = Console.ReadLine();
//TimeSpan lunchEnd = TimeSpan.Parse(lunchEndString);

//Console.Write("When did you go home from work? ");
//string endString = Console.ReadLine();
//TimeSpan end = TimeSpan.Parse(endString);

//Console.WriteLine();
//TimeSpan worktime = lunch - start + end - lunchEnd;

//Console.WriteLine($"You have worked {worktime.Hours}h and {worktime.Minutes} minutes");