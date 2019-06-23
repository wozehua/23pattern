using System;

namespace ObserverPattern_观察这模式_.OriginObserverPattern
{
    class StockObserver
    {
        private readonly string _name;
        private readonly Secretary _secretary;

        public StockObserver(string name,Secretary secretary)
        {
            _name = name;
            _secretary = secretary;
        }

        public void Update()
        {
            Console.WriteLine($"{_secretary.SecretaryAction} {_name} 关闭股票行情,继续工作!");
        }

    }
}
