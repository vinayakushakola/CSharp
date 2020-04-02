using System;
using System.Collections.Generic;

namespace DesignPattern.BehavioralDesignPattern.ObserverPattern.Youtube
{
    public class Channel : IYoutubeSubject
    {
        private List<Subscriber> subscribers = new List<Subscriber>();
        private String title;

        public void Subscribe(Subscriber sub)
        {
            subscribers.Add(sub);
        }

        public void UnSubscribe(Subscriber sub)
        {
            subscribers.Remove(sub);
        }

        public void NotifySubscriber()
        {
            foreach (Subscriber sub in subscribers)
            {
                sub.Update(this.title);
            }
        }

        public void Upload(String str)
        {
            this.title = str;
            NotifySubscriber();
        }
    }
}
