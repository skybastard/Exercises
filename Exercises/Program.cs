using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AsyncAwaitDemo;
using ExceptionsLibrary;
using GenericsDemo;
using InterfacesDemo;
using LinqDemo;
using TextFileDataDemo;
using Todo;


namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = ListManager.loadSampleData();

            //people = people.OrderBy(x => x.lastName).ToList();
            //people = people.OrderByDescending(x => x.lastName).ThenBy(x => x.yearsExperience).ToList();
            //people = people.Where(x => x.yearsExperience > 2 && x.birthday.Month == 2).ToList();
            //int yearsTotal = people.Sum(x => x.yearsExperience);
            int yearsTotal = 0;

            yearsTotal = people.Where(x => x.birthday.Month == 2).Sum(x => x.yearsExperience);



            Console.WriteLine(yearsTotal);

            foreach (var person in people)
            {
                Console.WriteLine($"{ person.firstName } { person.lastName } { person.birthday.ToShortDateString() } Experience { person.yearsExperience }");
            }


            Console.ReadLine();
        }


        
    }
}
