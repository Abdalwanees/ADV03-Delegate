
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Classes
{
    public delegate bool CompareFuncDelegate<T>(T A, T B);

    internal class SortingAlgorithms<T>
    {
        // Helper method to swap two elements
        private static void Swap(ref T x, ref T y)
        {
            T temp = x;
            x = y;
            y = temp;
        }

        // Bubble Sort with a comparison delegate
        public static void BubbleSort(T[] arr, CompareFuncDelegate<T> compareDelegate)
        {
            if (arr != null && compareDelegate != null)
            {
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    for (int j = 0; j < arr.Length - i - 1; j++)
                    {
                        if (compareDelegate(arr[j], arr[j + 1]))
                        {
                            Swap(ref arr[j], ref arr[j + 1]);
                        }
                    }
                }
            }
        }
    }
}