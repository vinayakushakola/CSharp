using System;

namespace DesignPattern.BehavioralDesignPattern.ObserverPattern.Youtube
{
    public class Subscriber : IYoutubeObserver
    {
        private Channel channel;
        private string _name;

        public Subscriber(string name)
        {
            this._name = name;
        }

        public void Update(string videoTitle)
        {
            Console.WriteLine("Hey! " + this._name + " Video Uploaded : " + videoTitle);
        }
    }
}
