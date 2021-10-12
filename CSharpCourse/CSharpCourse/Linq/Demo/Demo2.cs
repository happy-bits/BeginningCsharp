using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourse.Linq.Demo
{
    public class Demo2
    {
        public static void Run()
        {
            var person = new Person("Ludvig", 65);

            //person.Age       --> 65
            //person.FirstName --> "Ludvig"

            var people = new List<Person>
            {
                new Person("Ludvig", 65),
                new Person ("Alice", 28),
                new Person ("Fred", 30),
                new Person ("Zelda", 45)
            };

            IEnumerable<Person> result = PeopleOlderThan32(people);

            IEnumerable<Person> result_Linq = PeopleOlderThan32_Linq(people);


            IEnumerable<string> bonus = people
                .Where(p => p.Age > 32)
                .Select(p => $"{p.FirstName} is {p.Age} years old");


            var people_array = new Person[]
            {
                new Person("Ludvig", 65),
                new Person ("Alice", 28),
                new Person ("Fred", 30),
                new Person ("Zelda", 45)
            };

            var result2 = PeopleOlderThan32_Linq(people_array);

        }


        private static IEnumerable<Person> PeopleOlderThan32_Linq(IEnumerable<Person> people)
        {
            return people.Where(i => i.Age > 32);
        }

        private static IEnumerable<Person> PeopleOlderThan32(List<Person> people)
        {
            var result = new List<Person>();
            foreach (var p in people)
            {
                if (p.Age > 32)
                    result.Add(p);
            }
            return result;
        }
    }
}
