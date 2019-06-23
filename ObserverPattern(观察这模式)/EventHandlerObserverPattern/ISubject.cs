namespace ObserverPattern_观察这模式_.EventHandlerObserverPattern
{
    interface ISubject
    {
        void Notify();

        string SubjectState { get; set; }

    }
}
