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

        public static void PrimeNumberRange(int user_range)
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
                    Console.WriteLine("{0} is not a Prime Number", number);
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

        public static void CheckAnagram(string string1, string string2)
        {
            int i, flag = 0;

            if (string1.Length != string2.Length)
            {
                return;
            }

            char[] aS1 = new char[string1.Length];
            char[] aS2 = new char[string2.Length];

            for (i = 0; i < string1.Length; i++)
            {
                aS1[i] = string1[i];
            }

            for (i = 0; i < string2.Length; i++)
            {
                aS2[i] = string2[i];
            }

            aS1 = SortChar(aS1);
            aS2 = SortChar(aS2);

            for (i = 0; i < string1.Length; i++)
            {
                if (aS1[i] != aS2[i])
                {
                    flag = 1;
                    break;
                }
            }

            if (flag == 0)
            {
                Console.WriteLine(string1 + " and " + string2 + " are anagrams ");
            }
        }

        public static char[] SortChar(char[] s)
        {
            char temp;
            int length = s.Length;
            for(int i=0; i<length; i++)
            {
                for(int j=i+1; j<length;j++)
                {
                    if (s[i] > s[j])
                    {
                        temp = s[i];
                        s[i] = s[j];
                        s[j] = temp;
                    }
                }
            }
            return s;            
        }

        public static bool PrimeNumber(int num)
        {
            if (num > 1)
            {
                bool flag = true;
                for(int n=2; n<=num/2; n++)
                {
                    if (num%n == 0)
                    {
                        flag = false;
                        return false;
                    }
                }
                if (flag)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool IsPalindrome(int n)
        {
            int r, sum = 0;
            int temp = n;
            while (n > 0)
            {
                r = n % 10;
                sum = (sum * 10) + r;
                n = n / 10;
            }
            if (temp == sum)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void PrimeAnagramPalindrome(int num)
        {
            if (Utility.PrimeNumber(num))
            {
                Console.Write("{0} is Prime Number ", num);
                if (Utility.IsPalindrome(num))
                {
                    Console.Write("and Palindrome");
                }
                else
                {
                    Console.WriteLine("and not Palindrome");
                }
            }
            else
            {
                Console.WriteLine("{0} is not a Prime Number", num);
            }
        }
    }
}


