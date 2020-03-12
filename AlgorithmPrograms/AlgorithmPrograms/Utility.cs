using System;

namespace AlgorithmPrograms
{
    class Utility
    {
        public static void BubbleSort(int size, int[] arr)
        {
            for(int i=0; i<size; i++)
            {
                for(int j=0; j<size-1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            for(int n = 0; n < arr.Length; n++)
            {
                Console.Write(arr[n]+" ");
            }
            return;
        }

        public static void PrimeNumber(int user_range)
        {
            int number;

            for (number = 1; number < user_range; number++)
            {
                if (number > 1)
                {
                    int flag = 0;
                    for (int n = 2; n <= number / 2; n++)
                    {
                        if (number % n == 0)
                        {
                            flag = 1;
                            Console.WriteLine("{0} is not a Prime Number", number);
                            break;
                        }
                    }
                    if (flag == 0)
                    {
                        Console.WriteLine("{0} is a Prime Number", number);
                    }
                }
                else
                {
                    Console.WriteLine("{0} is not a Prime Number");
                }
            }
        }


        public static void InsertionSort(int[] arr)
        {
            int len = arr.Length;
            for (int i = 1; i < len; i++)
            {
                int current_position = arr[i];
                int j = i - 1;

                while (j >= 0 && arr[j] > current_position)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }

                arr[j + 1] = current_position;
            }

            for (int k=0; k<len; k++)
            {
                Console.Write(arr[k] + " ");
            }
        }
    }
}


