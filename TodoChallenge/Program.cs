using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            // Add "do some work as a TODO"
            // Print prints top 3
            // PrintAll prints all
            // Done marks it as done
            // Reorder by user input



            Console.WriteLine("Enter a TODO:");
            Todo myWork = new Todo();

            string description = Console.ReadLine();
            Todo.Add(description);
            

            Console.ReadLine();
            

        }
    }
}
