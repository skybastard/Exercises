using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TextFileDataDemo
{
    public class DataDemo
    {
        public string filePath = "C:/Users/ILS/Documents/test.txt";
        List<Person> people = new List<Person>();



        public void ReadText(string filePath)
        {
            List<string> lines = File.ReadAllLines(filePath).ToList();
            foreach(var line in lines)
            {
                Console.WriteLine(line);
            }
        }


        public void WriteText(string filePath)
        {
            List<string> linesToWrite = new List<string>() { "Martin", "Tamm", "C# harjutus" };

            File.WriteAllLines(filePath, linesToWrite);
        }


        //Populate list of persons
        public List<Person> PopulatePersonObject(string filePath)
        {
            List<Person> people = new List<Person>();
            List<string> lines = File.ReadAllLines(filePath).ToList();

            foreach(var line in lines)
            {
                string[] entries = line.Split(',');
                Person newPerson = new Person();
                // check to see if you have proper number of lines
                newPerson.firstName = entries[0];
                newPerson.lastName = entries[1];
                newPerson.URL = entries[2];

                people.Add(newPerson);
            }

            // show populated person
            foreach(var person in people)
            {
                Console.WriteLine($"{person.firstName } {person.lastName } : {person.URL}");
            }

            return people;
        }

        // save people data to file
        public void SavePersonObject(string filePath)
        {
            // populate people list with previous method and add another person
            PopulatePersonObject(filePath);
            people.Add(new Person { firstName = "OOF", lastName = "OOF", URL = "Homepage" });
            foreach (var person in people)
            {
                Console.WriteLine($"{person.firstName } {person.lastName } : {person.URL}");
            }


            List<string> output = new List<string>();

            foreach(var person in people)
            {
                output.Add($"{person.firstName }, {person.lastName}, {person.URL}");
            }
            Console.WriteLine("Writing to txt file");
            File.WriteAllLines(filePath, output);
            Console.WriteLine("All done writing");
        }


    }
}
