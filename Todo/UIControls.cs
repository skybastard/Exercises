using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo
{
    public static class UIControls
    {
        public static void UIinput()
        {
            Console.WriteLine("Commands: 1 = add, 2 = print TOP 3, 3 = printall, esc = save and exit");
            //ConsoleKey key = Console.ReadKey(true).Key;


            ConsoleKey key;
            do
            {
                key = Console.ReadKey(true).Key;
                switch (key)
                {
                    case ConsoleKey.D1:
                        Console.WriteLine("Enter new item: ");
                        MyToDoList.todoList.Add(Console.ReadLine());
                        break;

                    case ConsoleKey.D2:
                        MyToDoList.Print();
                        break;

                    case ConsoleKey.D3:
                        MyToDoList.Print();
                        break;

                    case ConsoleKey.Escape:
                        MyToDoList.SaveData();

                        break;
                    
                    default:
                        break;
                }



            } while (key != ConsoleKey.Escape);

        }
    }
}
