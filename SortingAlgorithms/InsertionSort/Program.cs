using System;

namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            InsertionSortOfAnArray(new int[5] { 83, 12, 3, 34, 60 }, 5);
        }

        private static void InsertionSortOfAnArray(int[] array, int element)
        {
            int i, j;

            for (i = 1; i < element; i++)
            {
                int item = array[i];
                int ins = 0;
                for (j = i - 1; j >= 0 && ins != 1;)
                {
                    if (item < array[j])
                    {
                        array[j + 1] = array[j];
                        j--;
                        array[j + 1] = item;
                    }
                    else
                    {
                        ins = 1;
                    }
                }
            }

            Console.WriteLine(string.Join(", ", array));
        }
    }
}
