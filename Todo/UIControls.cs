using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo
{
    public static class UIControls
    {
        public static void UIinput(string input)
        {
            Console.WriteLine("Commands: add, print, printall, exit");
            switch (input)
            {
                case "add":
                    Console.WriteLine("Enter new task:");
                    MyToDoList.todoList.Add(Console.ReadLine());
                    MyToDoList.printAll();
                    break;
                case "exit":
                    MyToDoList.SaveData();
                    Environment.Exit(0);
                    break;
                case "print":
                    MyToDoList.Print();
                    break;
                case "printall":
                    MyToDoList.printAll();
                    break;
                    // TODO add Done functionality and reorder functionality
                default:
                    break;
            }
            
        }
    }
}
