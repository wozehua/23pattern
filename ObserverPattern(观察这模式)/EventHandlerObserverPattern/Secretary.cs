namespace ObserverPattern_观察这模式_.EventHandlerObserverPattern
{
    /// <summary>
    /// 具体通知者类
    /// </summary>
    public delegate void EventHandler();
    class Secretary:ISubject
    {
        public event EventHandler Update;

        public string SubjectState { get; set; }

        public void Notify()
        {
            Update();
        }
    }
}
