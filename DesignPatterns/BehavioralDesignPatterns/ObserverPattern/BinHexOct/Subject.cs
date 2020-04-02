using System.Collections.Generic;

namespace DesignPattern.BehavioralDesignPattern.ObserverPattern.BinHexOct
{
    public class Subject
    {
        private List<Observer> observers = new List<Observer>();
        private int state;

        public void Add(Observer obs)
        {
            observers.Add(obs);
        }
        public int GetState()
        {
            return state;
        }

        public void SetState(int value)
        {
            this.state = value;
            Execute();
        }

        public void Execute()
        {
            foreach(Observer obs in observers)
            {
                obs.Update();
            }
        }
    }
}
