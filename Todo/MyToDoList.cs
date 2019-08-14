using System;
using System.Collections.Generic;
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
                Console.WriteLine(todoList[i]);
            }
        }

        public static void printAll()
        {
            foreach (var item in todoList)
            {
                Console.WriteLine(item);
            }
        }

        public static void SaveData()
        {
            //TODO streamwriter creates duplicates
            System.IO.StreamWriter file = new System.IO.StreamWriter(filePath, true);
            foreach (var item in todoList)
            {
                file.WriteLine(item);
            }
            todoList.Clear();
            file.Close();
        }

        public static void ReadData()
        {
            if (!System.IO.File.Exists(filePath))
            {
                System.IO.StreamWriter file = new System.IO.StreamWriter(filePath, true);
            }
            todoList = System.IO.File.ReadAllLines(filePath).ToList();
           
        }


    }
}
