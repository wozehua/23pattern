namespace IteratorPattern_迭代器模式_
{
    /// <summary>
    /// Aggregate 聚集抽象类
    /// </summary>
    abstract class Aggregate
    {
        public abstract Iterator CreateIterator();
    }
}
