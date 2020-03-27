using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CreationalDesignPatterns.SingletonLink
{
    public sealed class ThreadSafety
    {
        private static int counter = 0;
        private static readonly Object obj = new object();

        private ThreadSafety()
        {
            counter++;
            Console.WriteLine("Counter value: {0}", counter);
        }

        private static ThreadSafety instance = null;

        public static ThreadSafety Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (obj)
                    {
                        if (instance == null)
                            return instance = new ThreadSafety();
                    }
                }
                return instance;
            }
        }

        public void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
