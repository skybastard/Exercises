using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AsyncAwaitDemo;
using ExceptionsLibrary;
using GenericsDemo;
using InterfacesDemo;
using LinqDemo;
using TextFileDataDemo;
using Todo;


namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<Person> people = ListManager.loadSampleData();




            SumOfDigits(1556666);


            Console.ReadLine();
        }

        #region basics

        // 24 Find liongest word from sentence
        public static void longestInStrings(String input)
        {
            string[] sentence = input.Split(new[] { " " }, StringSplitOptions.None);
            int letterCount = 0;
            string longestWord = "";
            foreach (String word in sentence)
            {
                if (word.Length > letterCount)
                {
                    letterCount = word.Length;
                    longestWord = word;
                }
            }
            Console.WriteLine(longestWord);
        }

        // 26 print the sum of  first 500 prime numbers
        static void printPrimeSum(int numOfPrimes)
        {
            int counter = 0;
            int primeSum = 0;
            int n = 2;
            while(counter < numOfPrimes)
            {
                if (isPrime(n))
                {
                    primeSum += n;
                    counter++;
                }
                n++;
            }
            Console.WriteLine(primeSum);

        }

        static bool isPrime(int num)
        {
            if (num <= 1) return false;
            if (num == 2) return true;
            if (num % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(num));

            for (int i = 3; i <= boundary; i+=2)
            {
                if (num % i == 0) return false;
            }

            return true;
        }

        // 27 find the sum of digits of an integer
        static void SumOfDigits(int num)
        {
            int sum = 0;
            while (num != 0)
            {
                sum += num % 10;
                num /= 10;
            }
            Console.WriteLine($"sum of integer{ num } is { sum }");
        }

        #endregion



    }
}
