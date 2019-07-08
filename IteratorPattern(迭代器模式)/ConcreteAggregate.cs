using System.Collections.Generic;

namespace IteratorPattern_迭代器模式_
{
    class ConcreteAggregate:Aggregate
    {
        /// <summary>
        /// 声明一个IList泛型变量，用于存放聚合对象。
        /// </summary>
        private readonly IList<object> _items = new List<object>();
        public override Iterator CreateIterator()
        {
            return new ConcreteIterator(this);
        }
        /// <summary>
        /// 返回聚集总个数
        /// </summary>
        public int Count => _items.Count;

        //声明一个索引器
        public object this[int index]
        {
            get => _items[index];
            set => _items.Insert(index, value);
        }
    }
}
