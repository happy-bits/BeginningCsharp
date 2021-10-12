using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourse.Linq.Solutions
{
    public class TvShows
    {
        public static void Run()
        {
            string[] rows = ReadTvShowFile();

            IEnumerable<Show> allShows = ParseTvShows(rows);

            DisplayInfoAboutShows(allShows);

            // Extrauppgift, gör en funktion "ParseTvShows_Linq"
        }

        private static void DisplayInfoAboutShows(IEnumerable<Show> allShows)
        {

            // Skriv ut alla programtitlar

            Console.WriteLine("ALLA TITLAR");
            Console.WriteLine();

            var titlar = allShows.Select(s => s.Title);

            foreach(var titel in titlar)
            {
                Console.WriteLine(titel);
            }

            // Alla program som börjar senare än 21

            // todo: Fortsätt koda här!
        }

        private static IEnumerable<Show> ParseTvShows(string[] rows)
        {
            var allShows = new List<Show>();

            foreach (string line in rows)
            {
                /*
                   "line" kan t.ex se ut såhär:
                   SVT1*22:00*Fatta Sveriges demokrati
                */
                string[] splittedLine = line.Split('*');

                var show = new Show
                {
                    Channel = splittedLine[0],
                    StartAt = TimeSpan.Parse(splittedLine[1]),
                    Title = splittedLine[2],
                };

                allShows.Add(show);
            }
            return allShows;
        }

        private static string[] ReadTvShowFile()
        {
            return File.ReadAllLines(@"Linq\Solutions\tv-data.txt");
        }
    }
}
