using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            DataDemo fileData = new DataDemo();

            //fileData.ReadText(fileData.filePath);
            //fileData.WriteText(fileData.filePath);

            //fileData.PopulatePersonObject(fileData.filePath);

            fileData.SavePersonObject(fileData.filePath);

            Console.ReadLine();

        }

        
    }
}
