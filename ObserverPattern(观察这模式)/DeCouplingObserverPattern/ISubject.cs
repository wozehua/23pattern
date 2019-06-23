namespace ObserverPattern_观察这模式_.DeCouplingObserverPattern
{
    interface ISubject
    {
        void Attach(Observer observer);

        void DeAttach(Observer observer);

        void Notify();

        string SubjectState { get; set; }

    }
}
