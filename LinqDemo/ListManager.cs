using GenericsDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDemo
{
    public class ListManager
    {
        public static List<Person> loadSampleData()
        {
            List<Person> output = new List<Person>();
            output.Add(new Person { firstName = "Martin", lastName = "Tamm", birthday = Convert.ToDateTime("23.02.1987"), yearsExperience = 6 });
            output.Add(new Person { firstName = "Tim", lastName = "Corey", birthday = Convert.ToDateTime("11.03.1977"), yearsExperience = 16 });
            output.Add(new Person { firstName = "Sue", lastName = "Storm", birthday = Convert.ToDateTime("23.02.1967"), yearsExperience = 8 });
            output.Add(new Person { firstName = "Mari", lastName = "Tamm", birthday = Convert.ToDateTime("23.02.1947"), yearsExperience = 2 });
            output.Add(new Person { firstName = "Karu", lastName = "Misa", birthday = Convert.ToDateTime("23.02.1937"), yearsExperience = 1 });
            output.Add(new Person { firstName = "Karl", lastName = "Janes", birthday = Convert.ToDateTime("23.02.1997"), yearsExperience = 5 });

            return output;
        }

    }
}
