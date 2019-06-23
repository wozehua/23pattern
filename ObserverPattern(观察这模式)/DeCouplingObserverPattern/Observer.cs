namespace ObserverPattern_观察这模式_.DeCouplingObserverPattern
{
    /// <summary>
    /// 命名空间中的类型声明只可以具有public和Internal访问修饰符
    /// 类中类可以使用private private是一个成员访问修饰符的默认最低级别
    /// </summary>
    abstract class Observer
    {
        protected readonly string _name;
        protected readonly ISubject _subject;

        protected Observer(string name,ISubject subject)
        {
            _name = name;
            _subject = subject;
        }

        public abstract void Update();
    }
}
