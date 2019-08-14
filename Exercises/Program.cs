using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenericsDemo;
using InterfacesDemo;
using Todo;


namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {

            string filePath = "C:/Users/ILS/Documents/todo.txt";

            MyToDoList.printAll(filePath);
            Console.WriteLine();

            Console.WriteLine("Enter a TODO: ");
            string inputString = Console.ReadLine();
            MyToDoList.Add(inputString);

            MyToDoList.SaveData(MyToDoList.todoList, filePath);



            
            










            Console.ReadLine(); 



        }

        
    }
}
