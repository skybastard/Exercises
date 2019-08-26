using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo
{
    public static class MyToDoList
    {
        public static List<string> todoList { get; set; }
        public static string filePath = "C:/Users/ILS/Documents/todo.txt";

        public static void Add(string description)
        {
            todoList.Add(description);
            
        }

        public static void Print()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(i+". "+
                todoList[i]);
            }
        }

        public static void printAll()
        {
            int i = 1;
            foreach (var item in todoList)
            {
                Console.WriteLine(i+". " + item);
                i++;
            }
        }

        public static void SaveData()
        {
            File.WriteAllLines(filePath, todoList);
            
        }

        public static void ReadData()
        {
            todoList = File.ReadAllLines(filePath).ToList();
        }


    }
}
