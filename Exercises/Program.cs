using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenericsDemo;
using InterfacesDemo;

namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        { 
            

            DemonstrateTextFileStorage();

            Console.ReadLine(); 



        }

        private static void DemonstrateTextFileStorage()
        {
            List<Person> people = new List<Person>();
            List<LogEntry> logs = new List<LogEntry>();

            string peopleFile = @"D:\people.csv";
            string logFile = @"D:\logs.csv"; 

            PopulateLists(people, logs);
            GenericTextFileProcessor.SaveToTextFile<Person>(people, peopleFile);
            GenericTextFileProcessor.SaveToTextFile<LogEntry>(logs, logFile);

            var newPeople = GenericTextFileProcessor.LoadFromTextFile<Person>(peopleFile);

            foreach (var p in newPeople) 
            {
                Console.WriteLine($"{ p.FirstName } { p.LastName } (isAlive = { p.IsAlive}) ");
            }

            var newLogs = GenericTextFileProcessor.LoadFromTextFile<LogEntry>(logFile);
             
            foreach (var log in newLogs)
            {
                Console.WriteLine($"{ log.ErrorCode } { log.Message }  ");
            }


        }

        private static void PopulateLists(List<Person> people, List<LogEntry> logs)
        {
            people.Add(new Person { FirstName = "Tim", LastName = "Corey" });
            people.Add(new Person { FirstName = "Tim", LastName = "Corey" });
            people.Add(new Person { FirstName = "Tim", LastName = "Corey" });

            logs.Add(new LogEntry { Message = "im too awesome", ErrorCode = 1337 });
            logs.Add(new LogEntry { Message = "im tired", ErrorCode = 2222 });

        }
    }
}
