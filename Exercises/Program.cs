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
            MyToDoList.ReadData();
            while (true)
            {
                UIControls.UIinput(Console.ReadLine());
            }

            



        }

        
    }
}
