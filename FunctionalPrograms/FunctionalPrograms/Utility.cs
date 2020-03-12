using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalPrograms
{
    class Utility
    {
        public static void TwoDArray(int rows, int columns)
        {
            int[,] twoDArray = new int[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write("Enter for arr[{0},{1}] = ", i, j);
                    twoDArray[i, j] = Int32.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(twoDArray[i, j]);
                }
                Console.WriteLine();
            }
        }

        public static void TripletsAddZero(int size, int[] arr)
        {
            for (int i = 0; i < size - 2; i++)
            {
                for (int j = i + 1; j < size - 1; j++)
                {
                    for (int k = j + 1; k < size; k++)
                    {
                        if (arr[i] + arr[j] + arr[k] == 0)
                            Console.WriteLine("Triplets Add To Zero are: {0}, {1}, {2}", arr[i], arr[j], arr[k]);
                    }
                }
            }
        }

        public static void Distance(int x, int y)
        {
            double distance = Math.Sqrt(x*x+y*y);
            Console.WriteLine("Euclidean distance from the point ({0}, {1}) to the origin (0, 0) = {2}", x, y, distance);
        }

        public static void QuadraticEquation(int a, int b, int c)
        {
            double delta = b * b - 4 * a * c;
            Console.WriteLine("Delta: " + delta);
            if (delta > 0)
            {

                double squarerrootdelta = (Math.Sqrt(delta));
                Console.WriteLine("SquareRoot Of Delta: " + squarerrootdelta);
                double Root_1_of_x = (-b + (squarerrootdelta)) / (2 * a);
                double Root_2_of_x = (-b - squarerrootdelta) / (2 * a);
                Console.WriteLine("Root 1 Of X: " + Root_1_of_x);
                Console.WriteLine("Root 2 Of X :  " + Root_2_of_x);
            }
            else
            {
                Console.WriteLine("Negative Numbers Can't Have Squareroot!");
            }
        }

        public static void WindChill(double temp, double velocity)
        {
            double windchill = (35.74 + (0.6215 * temp) + (0.4275 * temp) - 35.75) * Math.Pow(velocity, 0.16);
            Console.WriteLine("WindChill: {0} ", windchill);
        }
    }
}
