using System;

namespace ObserverPattern_观察这模式_.EventHandlerObserverPattern
{
    class StockObserver
    {
        private string _name;
        private ISubject _subject;
        public StockObserver(string name,ISubject subject)
        {
            _name = name;
            _subject = subject;
        }

        public void CloseStockMarket()
        {
            Console.WriteLine($"{_subject.SubjectState} {_name} 关闭股票行情,继续工作!");
        }

    }

    class NBAObserver 
    {
        private string _name;
        private ISubject _subject;
        public NBAObserver(string name, ISubject subject)
        {
            _name = name;
            _subject = subject;
        }

        public  void CloseNbaDirectSeeding()
        {
            Console.WriteLine($"{_subject.SubjectState} {_name} 关闭NBA直播,继续工作！");
        }
    }
}
