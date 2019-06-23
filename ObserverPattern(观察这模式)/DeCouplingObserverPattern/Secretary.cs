using System.Collections.Generic;

namespace ObserverPattern_观察这模式_.DeCouplingObserverPattern
{
    class Secretary:ISubject
    {
        /// <summary>
        /// 观察者列表
        /// </summary>
        private readonly IList<Observer> _observers = new List<Observer>();

        //添加观察者
        public void Attach(Observer observer)
        {
            _observers.Add(observer);
        }
        /// <summary>
        /// 移除观察者
        /// </summary>
        /// <param name="observer"></param>
        public void DeAttach(Observer observer)
        {
            _observers.Remove(observer);
        }

        public string SubjectState { get; set; }

        public void Notify()
        {
            foreach (var item in _observers)
            {
                item.Update();
            }
        }
    }
}
