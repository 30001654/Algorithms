using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[1000];
            int[] array2 = new int[1000];
            int[] array3 = new int[1000];
            Populate(array);
            ArrayClone(array, array2, array3);
            StandardBubbleSort(array);
            ImprovedBubbleSort(array2);
            DisplayUnsorted(array3);
            DisplaySort(array);
            DisplaySort2(array2);
            Console.ReadLine();
        }

        public static void ArrayClone(int[] array, int[] array2, int[] array3)
        {
            for (int i = 0; i < array.Length-1; i++)
            {
                array2[i] = array[i];
                array3[i] = array[i];
            }
            Console.WriteLine("Array cloned.");
        }

        public static void Populate(int[] array)
        {
            for (int i = 0; i < array.Length-1; i++)
            {
                array[i] = GetRandomNumber(0, 1000);
            }
            Console.WriteLine("Array populated.");
        }

        private static readonly Random random = new Random();
        private static readonly object syncLock = new object();
        public static int GetRandomNumber(int min, int max)
        {
            lock (syncLock)
            {
                return random.Next(min, max);
            }
        }

        public static int[] StandardBubbleSort(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine("Array sorted.");
            return array;
        }

        public static int[] ImprovedBubbleSort(int[] array2)
        {
            bool swap = true;
            for (int i = 0; i < array2.Length-1; i++)
            {
                swap = false;
                for (int j = 0; j < array2.Length-1; j++)
                {
                    if(array2[j] > array2[j+1]){
                        int temp = array2[j];
                        array2[j] = array2[j + 1];
                        array2[j + 1] = temp;
                        swap = true;
                    }
                }
                if (!swap)
                {
                    break;
                }
            }
            Console.WriteLine("Array sorted.");
            return array2;
        }

        public static void DisplayUnsorted(int[] array3)
        {
            string display = "";
            Console.WriteLine("===============================");
            Console.WriteLine("Unsorted.");
            Console.WriteLine("Displaying Array.");
            for (int i = 0; i < array3.Length - 1; i++)
            {
                display += array3[i] + " ";
            }
            Console.WriteLine(display);
            Console.WriteLine("\n");
        }

        public static void DisplaySort(int[] array)
        {
            string display = "";
            Console.WriteLine("===============================");
            Console.WriteLine("Standard Sorting.");
            Console.WriteLine("Displaying Array.");
            for (int i = 0; i < array.Length - 1; i++)
            {
                display += array[i] + " ";
            }
            Console.WriteLine(display);
            Console.WriteLine("\n");
        }

        public static void DisplaySort2(int[] array2)
        {
            string display = "";
            Console.WriteLine("===============================");
            Console.WriteLine("Improved Sorting.");
            Console.WriteLine("Displaying Array.");
            for(int i = 0; i < array2.Length-1; i++)
            {
                display += array2[i] + " ";
            }
            Console.WriteLine(display);
            Console.WriteLine("\n");
        }
    }
}
