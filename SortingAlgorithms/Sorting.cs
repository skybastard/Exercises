using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    public class Sorting
    {

        public static int[] MakeArray()
        {
            Random rnd = new Random();
            int[] inputArray = new int[5000];
            for (int i = 0; i < 5000; i++)
            {
                inputArray[i] = rnd.Next(1, 500);
            }
            return inputArray;
        }
        public static void PrintResultArrya(int[] sortedArray)
        {
            foreach (var item in sortedArray)
            {
                Console.Write(item + " ");
            }
        }


        // Shell sort
        public static void ShellSort(int[] input)
        {
            System.Diagnostics.Stopwatch timer = new System.Diagnostics.Stopwatch();
            timer.Start();

            int i, j, inc, temp;
            inc = 3;
            while (inc > 0)
            {
                for (i = 0; i < input.Length; i++)
                {
                    j = i;
                    temp = input[i];
                    while ((j >= inc) && (input[j - inc] > temp))
                    {
                        input[j] = input[j - inc];
                        j = j - inc;
                    }
                    input[j] = temp;
                }
                if (inc / 2 != 0)
                {
                    inc = inc / 2;
                }
                else if (inc == 1)
                {
                    inc = 0;
                }
                else
                {
                    inc = 1;
                }
            }
            timer.Stop();
            //PrintResultArrya(input);
            TimeSpan ts = timer.Elapsed;
            Console.WriteLine($"\n it took Shellsort { ts.TotalSeconds } seconds");
        }

        //Bubble sort
        public static void BubbleSort(int[] input)
        {
            System.Diagnostics.Stopwatch timer = new System.Diagnostics.Stopwatch();
            timer.Start();
            int temporary;
            for (int p = 0; p <= input.Length - 2; p++)
            {
                for (int i = 0; i <= input.Length - 2; i++)
                {
                    if (input[i] > input[i + 1])
                    {
                        temporary = input[i + 1];
                        input[i + 1] = input[i];
                        input[i] = temporary;
                    }
                }
            }
            timer.Stop();
            TimeSpan ts = timer.Elapsed;
            //PrintResultArrya(input);
            Console.WriteLine($"\n it took Bubblesort { ts.TotalSeconds } seconds");
        }

        //Counting sort
        public static void CountingSort(int[] input)
        {
            System.Diagnostics.Stopwatch timer = new System.Diagnostics.Stopwatch();
            timer.Start();
            int[] sortedArray = new int[input.Length];
            // find the smallest and largest value
            int minVal = input[0];
            int maxVal = input[0];
            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] < minVal)
                {
                    minVal = input[i];
                }
                else if (input[i] > maxVal)
                {
                    maxVal = input[i];
                }
            }
            // init array of frequencies
            int[] counts = new int[maxVal - minVal + 1];
            // init the frequencies
            for (int i = 0; i < input.Length; i++)
            {
                counts[input[i] - minVal]++;
            }
            // recalculate
            counts[0]--;
            for (int i = 1; i < counts.Length; i++)
            {
                counts[i] = counts[i] + counts[i - 1];
            }
            // sort the array
            for (int i = input.Length - 1; i >= 0; i--)
            {
                sortedArray[counts[input[i] - minVal]--] = input[i];
            }
            timer.Stop();
            TimeSpan ts = timer.Elapsed;
            //PrintResultArrya(sortedArray);
            Console.WriteLine($"\n it took Counting sort { ts.TotalSeconds } seconds");
        }

        //Heap sort
        public static void HeapSort<T>(T[] array) where T : IComparable<T>
        {
            System.Diagnostics.Stopwatch timer = new System.Diagnostics.Stopwatch();
            timer.Start();
            int heapSize = array.Length;

            buildMaxHeap(array);

            timer.Stop();
            TimeSpan ts = timer.Elapsed;
            //PrintResultArrya(sortedArray);
            Console.WriteLine($"\n it took Heap sort { ts.TotalSeconds } seconds");
        }

        public static void buildMaxHeap<T>(T[] array) where T : IComparable<T>
        {
            int heapSize = array.Length;

            for (int i = (heapSize / 2) - 1; i >= 0; i--)
            {
                sink(array, heapSize, i);
            }
        }

        private static void sink<T>(T[] array, int heapSize, int toSinkPos) where T : IComparable<T>
        {
            if (getLeftKidPos(toSinkPos) >= heapSize)
            {
                return;
            }

            int largestKidPos;
            bool leftIsLargest;

            if (getRightKidPos(toSinkPos) >= heapSize || array[getRightKidPos(toSinkPos)].
                CompareTo(array[getLeftKidPos(toSinkPos)]) < 0)
            {
                largestKidPos = getLeftKidPos(toSinkPos);
                leftIsLargest = true;
            }
            else
            {
                largestKidPos = getRightKidPos(toSinkPos);
                leftIsLargest = false;
            }

            if (array[largestKidPos].CompareTo(array[toSinkPos]) > 0)
            {
                swap(array, toSinkPos, largestKidPos);

                if (leftIsLargest)
                {
                    sink(array, toSinkPos, getLeftKidPos(toSinkPos));
                }
                else
                {
                    sink(array, heapSize, getRightKidPos(toSinkPos));
                }
            }

        }

        private static void swap<T>(T[] array, int pos0, int pos1)
        {
            T tmpVal = array[pos0];
            array[pos0] = array[pos1];
            array[pos1] = tmpVal;
        }

        private static int getLeftKidPos(int parentPos)
        {
            return (2 * (parentPos + 1)) - 1;
        }

        private static int getRightKidPos(int parentPos)
        {
            return 2 * (parentPos + 1);
        }

        //Insertion sort
        public static void insertionSort(int[] inputArray)
        {
            System.Diagnostics.Stopwatch timer = new System.Diagnostics.Stopwatch();
            timer.Start();
            for (int i = 0; i < inputArray.Length - 1; i++)
            {
                for(int j = i + 1; j > 0; j--)
                {
                    if(inputArray[j - 1] > inputArray[j])
                    {
                        int temp = inputArray[j - 1];
                        inputArray[j - 1] = inputArray[j];
                        inputArray[j] = temp;
                    }
                }
            }
            timer.Stop();
            //PrintResultArrya(input);
            TimeSpan ts = timer.Elapsed;
            Console.WriteLine($"\n it took InsertionSort { ts.TotalSeconds } seconds");
        }

        //Merge Sort
        public static int[] mergeSort(int[] inputArray)
        {
            System.Diagnostics.Stopwatch timer = new System.Diagnostics.Stopwatch();
            timer.Start();
            int[] left = new int[inputArray.Length / 2];
            int[] right = new int[inputArray.Length / 2];

            int middle = (inputArray.Length / 2) - 1;
            for (int i = 0; i < middle; i++)
            {
                
                left[i] = inputArray[i];
            }
            for(int i = middle; i <= inputArray.Length; i++)
            {
                right[i] = inputArray[i];
            }
               
            
                
            left = mergeSort(left);
            right = mergeSort(right);
            return merge(left, right);

            timer.Stop();
            //PrintResultArrya(input);
            TimeSpan ts = timer.Elapsed;
            Console.WriteLine($"\n it took Merge sort { ts.TotalSeconds } seconds");
        }

        static int[] merge(int[] left, int[] right)
        {
            List<int> result = new List<int>();
            int[] resultArray = new int[left.Length + right.Length];
            while(left.Length > 0 || right.Length > 0)
            {
                if(left.Length > 0 && right.Length > 0)
                {
                    if(left[0] <= right[0])
                    {
                        result.Add(left[0]);
                        int numToRemove = left[0];
                        left = left.Where(val => val != numToRemove).ToArray();
                    }
                    else
                    {
                        result.Add(right[0]);
                        int numToRemove = right[0];
                        right = right.Where(val => val != numToRemove).ToArray();
                    }
                }else if(left.Length > 0)
                {
                    result.Add(right[0]);
                    int numToRemove = right[0];
                    right = right.Where(val => val != numToRemove).ToArray();
                }
            }
            for(int i = 0; i < result.Count; i++)
            {
                resultArray[i] = result.IndexOf(i);
            }
            return resultArray; ;
        }

        //Quick sort
        public static void quickSort(int[] inputArray, int left, int right)
        {
            
            if (left < right)
            {
                int pivot = partition(inputArray, left, right);
                if(pivot > 1)
                {
                    quickSort(inputArray, left, pivot - 1);
                }
                if(pivot + 1 < right)
                {
                    quickSort(inputArray, pivot + 1, right);
                }
            }
            
        }
        static int partition(int[] array, int left, int right)
        {
            int pivot = array[left];
            while (true)
            {
                while(array[left] < pivot)
                {
                    left++;
                }
                while(array[right] > pivot)
                {
                    right--;
                }
                if(left < right)
                {
                    if (array[left] == array[right]) return right;
                    int temp = array[left];
                    array[left] = array[right];
                    array[right] = temp;
                }
                else
                {
                    return right;
                }
            }
        }

    }
}
