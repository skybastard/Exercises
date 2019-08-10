using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfacesDemo;

namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> ages = new List<int>();
 


        }

        private static void DemonstrateTextFileStorage()
        {
            List<Person> people = new List<Person>();
            List<LogEntry> logs = new List<LogEntry>();

            string peopleFile = @"C:\people.csv";
            string logFile = @"C:\logs.csv";

            PopulateLists(people, logs);

            OriginalTextFileProcessor.SavePeople(people, peopleFile);

            var newPeople = OriginalTextFileProcessor.LoadPeople(peopleFile);

            foreach(var p in newPeople)
            {
                Console.WriteLine($"{ p.FirstName } { p.LastName } (isAlive = { p.IsAlive}) ");
            }
        }

        private static void PopulateLists(List<Person> people, List<LogEntry> logs)
        {
            people.Add(new Person { FirstName = "Tim", LastName = "Corey" });
            people.Add(new Person { FirstName = "Tim", LastName = "Corey" });
            people.Add(new Person { FirstName = "Tim", LastName = "Corey" });

            logs.Add(new LogEntry { Message = "im too awesome", ErrorCode = "1337" });
            logs.Add(new LogEntry { Message = "im tired", ErrorCode = 2222 });

        }
    }
}
