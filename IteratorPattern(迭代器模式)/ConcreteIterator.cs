namespace IteratorPattern_迭代器模式_
{
    class ConcreteIterator:Iterator
    {
        /// <summary>
        /// 定义一个具体聚集对象
        /// </summary>
        private readonly ConcreteAggregate _concreteAggregate;
        private int _current;

        /// <summary>
        /// 初始化时将具体的聚集对象传入
        /// </summary>
        /// <param name="concreteAggregate"></param>
        public ConcreteIterator(ConcreteAggregate concreteAggregate)
        {
            _concreteAggregate = concreteAggregate;
        }
        /// <summary>
        /// 得到聚集的第一个对象
        /// </summary>
        /// <returns></returns>
        public override object First()
        {
            return _concreteAggregate[0];
        }

        /// <summary>
        /// 得到聚集的下一个对象
        /// </summary>
        /// <returns></returns>
        public override object Next()
        {
            object ret = null;
            _current++;
            if (_current < _concreteAggregate.Count)
            {
                ret = _concreteAggregate[_current];
            }
            return ret;
        }
        /// <summary>
        /// 判断当前是否遍历到结尾，到结尾返回true
        /// </summary>
        /// <returns></returns>
        public override bool IsDone()
        {
            return _current >= _concreteAggregate.Count;
        }

        public override object CurrentItem()
        {
            return _concreteAggregate[_current];
        }
    }
}
