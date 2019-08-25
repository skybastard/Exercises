using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AsyncAwaitDemo;
using ExceptionsLibrary;
using GenericsDemo;
using InterfacesDemo;
using TextFileDataDemo;
using Todo;


namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine();
            Console.WriteLine("Simple Async Demo App");
            Console.WriteLine();
            Console.WriteLine("Press 1 for Normal Execute");
            Console.WriteLine("Press 2 for Async Execute");

            ConsoleKey key;
            do
            {
                // Key is available - read it
                key = Console.ReadKey(true).Key;

                if (key == ConsoleKey.D1)
                {
                    WebsiteDownload.NormalExecute();
                }
                else if (key == ConsoleKey.D2)
                {
                    WebsiteDownload.AsyncExecute();
                }

            } while (key != ConsoleKey.Escape);

            Console.WriteLine();

        }

        
    }
}
