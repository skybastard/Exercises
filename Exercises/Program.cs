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
using System.IO;
using SortingAlgorithms;


namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<Person> people = ListManager.loadSampleData();

            FileHandling fileHandler = new FileHandling();

            //fileHandler.removeFile("some filename");
            //fileHandler.writeLinesToFile();
            //fileHandler.addToExistingFile();
            //fileHandler.copyFileToAnotherName();
            fileHandler.moveFileToFolder();



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
            while (counter < numOfPrimes)
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

            for (int i = 3; i <= boundary; i += 2)
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

        // 28 reverse words of a sentence
        static void ReverseCentence()
        {
            string input = "This is my centece that i will reverse so it will be awesome";
            string[] words = input.Split(new[] { " " }, StringSplitOptions.None);
            string result = "";
            for (int i = words.Length - 1; i >= 0; i--)
            {
                result += words[i] + " ";
            }
            Console.WriteLine(result);
        }

        // 29 find the size of a file
        string filepath = "D:\\Download\\OrbxFTXTreesHD100";
        static void FileSize(string path)
        {
            FileInfo fileInfo = new FileInfo(path);
            Console.WriteLine(fileInfo.Length.ToString());
        }

        // 30 convert hex to decimal
        static void HexToDecimal(string hexVal)
        {
            int decimalValue = int.Parse(hexVal, System.Globalization.NumberStyles.HexNumber);
            Console.WriteLine(decimalValue);
        }

        // 31 multiply array elements
        static void MultiplyArrays()
        {
            int[] array1 = { 2, 1, 4, 5, 6, 7 };
            int[] array2 = { 4, 6, 3, 7, 78, 9 };
            int[] output = new int[array1.Length];

            for (int i = 0; i < array1.Length; i++)
            {
                output[i] = array1[i] * array2[i];
                Console.WriteLine(output[i]);
            }

        }

        // 32 write 4 copies of last 4 strings in sentence
        //string input = "This is my sentece that i will reverse so it will be awesome";
        static void CopyFourLastStrings(string input)
        {
            string output = "";
            for (int i = 0; i < 4; i++)
            {
                output += input.Substring(input.Length - 4);
            }
            Console.WriteLine(output);
        }

        // 41 check if string contains w 1 to 3 times
        static void CheckForWWW(string input)
        {
            int counter = input.Count(s => s == 'w');
            Console.WriteLine(counter >= 1 && counter <= 3);

        }

        // 44 make a string of every other character
        static void OddCharacters()
        {
            string input = "This is my sentece that i will reverse so it will be awesome";
            string output = "";
            for (int i = 0; i < input.Length; i++)
            {
                if (i % 2 == 0)
                {
                    output += input[i];
                }

            }
            Console.WriteLine(output);
        }

        // 56 check if string is a palindrome
        static void CheckPalindrome(string input)
        {
            char[] inputChar = input.ToCharArray();
            string output = inputChar.Reverse().ToString();
            if (output.Equals(input))
            {
                Console.WriteLine($"Yes { input } is a palindrome");
            }
            else
            {
                Console.WriteLine($"{ input } is not a palindrome");
            }
        }

        // 61 sort array of integers, leave integer 5 into its place        
        static void SortButFive(int[] input)
        {
            int[] num = input.Where(x => x != 5).OrderBy(x => x).ToArray();
            int counter = 0;
            num.Select(x => x >= 0 ? num[counter++] : 5).ToArray();
            foreach (var item in num)
            {
                Console.WriteLine(item);
            }
        }



        #endregion

        #region basic algorithm

        //6 remove string from position n
        public static void RemoveCharacter(int n, string inputWord)
        {
            if (n > inputWord.Length)
            {
                Console.WriteLine("there are less letters in that word");
                return;
            }
            Console.WriteLine(inputWord.Remove(n, 1));
        }

        //7 swap first and last letter of a string
        static void SwapFirstAndLastLetter(string input)
        {
            string output = input.Substring(input.Length - 1) +
                input.Substring(1, input.Length - 2) +
                input.Substring(0, 1);
            Console.WriteLine(output);
        }

        //24 make last 3 characters uppercase, if less than 3 all uppercase
        static string LastThreeUppercase(string input)
        {
            if (input.Length <= 3)
            {
                return input.ToUpper();
            }
            else
            {
                string output = input.Substring(0, input.Length - 3) +
                    input.Substring(input.Length - 3).ToUpper();
                return output;
            }
        }



        #endregion

        #region struct

        struct StructNumbers
        {
            public int x;
            public int y;
        }
        struct Employee
        {
            public string firstName { get; set; }
            public DateOfBirth birthday;
        }
        struct DateOfBirth
        {
            public int day;
            public int month;
            public int year;
        }

        static void AddStructElements(dynamic x, dynamic y)
        {
            dynamic answer = x + y;
            Console.WriteLine(answer);

        }
        static void EmployeeMethod()
        {
            Employee martin = new Employee() { firstName = "Martin", birthday = new DateOfBirth { day = 23, month = 2, year = 1987 } };
            Console.WriteLine($"{martin.firstName}, {martin.birthday.day}, {martin.birthday.month}, {martin.birthday.year}");
        }

        struct SomeStruct
        {
            private int num;
            public int n
            {
                get { return num; }
                set { if (value < 50) num = value; }
            }

            public void clsMethod()
            {
                Console.WriteLine("The stored value is: {0}", num);
            }




        }

        
       

            






        #endregion

     


    }
}
