using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CreationalDesignPatterns.SingletonLink
{
    /*
     * Pre-Instantiation of the object
     * Commonly used in lower memory footprints
     */
    public sealed class EagerInitialization
    {
        private static int counter = 0;

        private EagerInitialization()
        {
            counter++;
            Console.WriteLine("Counter value: {0}", counter);
        }

        private static readonly EagerInitialization instance = new EagerInitialization();

        public static EagerInitialization Instance
        {
            get
            {
                return instance;
            }
        }

        public void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
