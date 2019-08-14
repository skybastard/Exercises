using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo
{
    public static class MyToDoList
    {
        public static List<string> todoList { get; set; } = new List<string>();

        public static void Add(string description)
        {
            todoList.Add(description);
            //SaveData(todoList, filePath);
        }


        public static void Print()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(todoList[i]);
            }
        }

        public static void printAll(string filePath)
        {
            ReadData(filePath);
            foreach (var item in todoList)
            {
                Console.WriteLine(item);
            }
        }

        public static void SaveData(List<string> todoList,string filePath)
        {
            System.IO.StreamWriter file = new System.IO.StreamWriter(filePath, true);
            foreach (var item in todoList)
            {
                file.WriteLine(item);
            }
            todoList.Clear();
            file.Close();
        }

        public static List<string> ReadData(string filePath)
        {
            if (!System.IO.File.Exists(filePath))
            {
                System.IO.StreamWriter file = new System.IO.StreamWriter(filePath, true);
            }
            todoList = System.IO.File.ReadAllLines(filePath).ToList();
            return todoList;
        }


    }
}
