using DesignPattern.BehavioralDesignPattern.ObserverPattern.Youtube;
using System;

namespace DesignPatterns.BehavioralDesignPatterns.ObserverPattern.Youtube
{
    class YoutubeProgram
    {
        public static void YoutubeRun()
        {
            try
            {
                Channel Believer = new Channel();

                Subscriber s1 = new Subscriber("Ravi");
                Subscriber s2 = new Subscriber("Amit");
                Subscriber s3 = new Subscriber("Sarva");
                Subscriber s4 = new Subscriber("Sid");
                Subscriber s5 = new Subscriber("Vassu");

                Believer.Subscribe(s1);
                Believer.Subscribe(s2);
                Believer.Subscribe(s3);
                Believer.Subscribe(s4);
                Believer.Subscribe(s5);

                Believer.Upload("Maximize your memory!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Message: {0}", ex.Message);
            }
        }
    }
}
