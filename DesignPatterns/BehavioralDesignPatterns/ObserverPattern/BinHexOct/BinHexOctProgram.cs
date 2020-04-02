using DesignPattern.BehavioralDesignPattern.ObserverPattern.BinHexOct;
using System;

namespace DesignPatterns.BehavioralDesignPatterns.ObserverPattern.BinHexOct
{
    class BinHexOctProgram
    {
        public static void BinHexOctRun()
        {
            try
            {
                Subject sub = new Subject();

                // Client configures the number and type of Observers
                new HexObserver(sub);
                new OctObserver(sub);
                new BinObserver(sub);

                for (int i = 0; i < 2; i++)
                {
                    Console.Write("\nEnter a number: ");
                    sub.SetState(Convert.ToInt32(Console.ReadLine()));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Message: {0}", ex.Message);
            }
        }
    }
}
