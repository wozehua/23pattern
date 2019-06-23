using System.Collections.Generic;

namespace ObserverPattern_观察这模式_.OriginObserverPattern
{
    class Secretary
    {
        /// <summary>
        /// 同事列表
        /// </summary>
        private readonly IList<StockObserver> _stockObservers = new List<StockObserver>();

        public void Attach(StockObserver stockObserver)
        {
            _stockObservers.Add(stockObserver);
        }

        public void Notify()
        {
            foreach (var item in _stockObservers)
            {
                item.Update();
            }
        }

        public string SecretaryAction { get; set; }
    }
}
