using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPrograms
{
    class InsertionSort
    {
        public static void Input()
        {
            Console.Write("Enter the size of the array: ");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[size];
            for (int j=0; j<size; j++)
            {
                Console.Write("Enter element: ");
                arr[j] = Convert.ToInt32(Console.ReadLine());
            }
            Utility.InsertionSort(arr);
        }
    }
}
