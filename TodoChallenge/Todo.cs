using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoChallenge
{
    public class Todo
    {
        public string description { get; set; }
        public List<string> todoList { get; set; }

        public  void Add(string description)
        {
            todoList.Add(description);
        }

        public  void Print()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(todoList[i]);
            }
        }

        public void printAll()
        {
            foreach(var item in todoList)
            {

            }
        }


    }
}
