using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsLibrary
{
    public class DemoCode
    {

        public int GrandParentMethod(int position)
        {
            int output = 0;
            Console.WriteLine("Open database connection");

            try
            {
                output = ParentMethod(position);
            }
            catch (Exception ex)
            {
                // Do some logging, pass up the chain
                throw;
            }
            finally
            {
                Console.WriteLine("Close database connection");
            }

           
            return output;
        }

        public int ParentMethod(int position)
        {
            return GetNumber(position);
        }

        public int GetNumber(int position)
        {
            int output = 0;
            //try
            //{
                int[] numbers = new int[] { 1, 4, 7, 2 };
                output = numbers[position];
            //}
            //catch (Exception ex)
            //{
             //   Console.WriteLine(ex.Message);
             //   Console.WriteLine(ex.StackTrace);
                
            //}
            return output;
        }




    }
}
