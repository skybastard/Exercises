using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDemo
{
    public class Person
    {

        public string firstName { get; set; }
        public bool isAlive { get; set; }
        public string lastName { get; set; }
        public string URL { get; set; }
        public int yearsExperience { get; set; }
        public DateTime birthday { get; set; }

        public string fullname
        {
            get
            {
                return $"{firstName }{ lastName}";
            }
        }

        public void SayHello()
        {
            Console.WriteLine($"Hello { firstName }{lastName}"  );
        }

        
    }

   
}
