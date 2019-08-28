using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDemo
{
    public class OriginalTextFileProcessor
    {
        public static List<Person> LoadPeople(string filePath)
        {
            List<Person> output = new List<Person>();
            Person p;
            var lines = System.IO.File.ReadAllLines(filePath).ToList();
            //Remove header row
            lines.RemoveAt(0);

            foreach(var line in lines)
            {
                var vals = line.Split(',');
                p = new Person();

                p.firstName = vals[0];
                p.isAlive = bool.Parse(vals[1]);
                p.lastName = vals[2];

                output.Add(p);
            }
            return output; 
        }

        public static void SavePeople(List<Person> people, string filePath)
        {
            List<string> lines = new List<string>();

            //Add header row
            lines.Add("firstName, isAlive, LastName");

            foreach(var p in people)
            {
                lines.Add($"{ p.firstName }, { p.isAlive }, { p.lastName }");
            }

            System.IO.File.WriteAllLines(filePath, lines);        }







    }
}
