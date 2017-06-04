using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Самостоятельная_работа__01
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 11, 8, 3, 55, 56, 15, 5555, 55, 98, 1, 0 };
            QSort(arr, 0, arr.Length - 1);
            foreach (int arrs in arr)
            {
                Console.WriteLine(arrs);
            }
        }

        static void QSort(int[] arr, int first, int last)
        {
            int pivot = ((first + last) / 2);
            int i = first;
            int j = last;

            while (i <= j)
            {
                while (arr[i] < arr[pivot]) { i++; }
                while (arr[j] > arr[pivot]) { j--; }

                if (i <= j)
                {
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                    i++;
                    j--;
                }
            }

            if (first <= j) { QSort(arr, first, j); }
            if (i <= last) { QSort(arr, i, last); }
        }
    }
}
