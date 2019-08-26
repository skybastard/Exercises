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
            
            MyToDoList.ReadData();
            MyToDoList.Print();
            UIControls.UIinput();

        }


        static string GetMessage()
        {
            return "This is a test";
        }

        
    }
}
