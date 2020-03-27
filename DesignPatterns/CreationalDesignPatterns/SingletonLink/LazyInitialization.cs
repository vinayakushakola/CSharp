using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CreationalDesignPatterns.SingletonLink
{
    public sealed class LazyInitialization
    {
        private static int counter = 0;

        private LazyInitialization()
        {
            counter++;
            Console.WriteLine("Counter value: {0}", counter);
        }

        private static readonly Lazy<LazyInitialization> instance = new Lazy<LazyInitialization>(() => new LazyInitialization());

        public static LazyInitialization GetInstance
        {
            get
            {
                return instance.Value;
            }
        }

        public void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
