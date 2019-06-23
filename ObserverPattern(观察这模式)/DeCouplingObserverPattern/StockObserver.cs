using System;

namespace ObserverPattern_观察这模式_.DeCouplingObserverPattern
{
    class StockObserver:Observer
    {
        public StockObserver(string name,ISubject subject):base(name,subject)
        {
        }

        public override void Update()
        {
            Console.WriteLine($"{_subject.SubjectState} {_name} 关闭股票行情,继续工作!");
        }

    }

    class NBAObserver : Observer
    {
        public NBAObserver(string name, ISubject subject) : base(name, subject)
        {
        }

        public override void Update()
        {
            Console.WriteLine($"{_subject.SubjectState} {_name} 关闭NBA直播,继续工作！");
        }
    }
}
