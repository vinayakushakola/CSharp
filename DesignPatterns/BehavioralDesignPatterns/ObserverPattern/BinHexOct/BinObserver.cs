using System;

namespace DesignPattern.BehavioralDesignPattern.ObserverPattern.BinHexOct
{
    class BinObserver : Observer
    {
        public BinObserver(Subject sub)
        {
            this.subject = sub;
            subject.Add(this);
        }
        public override void Update()
        {
            Console.WriteLine(" " + Convert.ToString(subject.GetState(), 2));
        }
    }
}
