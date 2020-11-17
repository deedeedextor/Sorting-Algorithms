using System;

namespace SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            SelectionSortOfAnArray(new int[10] { 100, 50, 20, 40, 10, 60, 80, 70, 90, 30 });
        }

        private static void SelectionSortOfAnArray(int[] array)
        {
            int temp, min;

            for (int i = 0; i < array.Length - 1; i++)
            {
                min = i;

                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[min])
                    {
                        min = j;
                    }
                }

                temp = array[min];
                array[min] = array[i];
                array[i] = temp;
            }

            Console.WriteLine(string.Join(", ", array));
        }
    }
}
