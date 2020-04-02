namespace DesignPattern.BehavioralDesignPattern.ObserverPattern.Youtube
{
    interface IYoutubeSubject
    {
        void NotifySubscriber();
        void Subscribe(Subscriber sub);
        void UnSubscribe(Subscriber sub);
        void Upload(string str);
    }
}