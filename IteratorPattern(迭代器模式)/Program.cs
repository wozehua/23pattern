using System;

namespace IteratorPattern_迭代器模式_
{
    /// <summary>
    /// 迭代器模式：提供一种方法顺序访问一个聚合对象中各个元素，而又不暴露该对象的内部表示
    /// 当你需要访问一个聚集对象，而且不管这些对象是什么都需要遍历的时候，你就应该考虑用迭代器模式。
    /// 还有就是：你需要对聚集有多种方式遍历时，可以考虑用迭代器模式。
    /// 为遍历不同的聚集结构提供如开始、下一个、是否结束、当前哪一项等同一接口。
    /// 迭代器模式就是分离了集合对象的遍历行为，抽象出一个迭代器类来负责，这样既可以不暴露集合的内部结构，又可
    /// 让外部代码透明地访问集合内部的数据。
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var concreteAggregate = new ConcreteAggregate
            {
                [0] = "大鸟",
                [1] = "小菜",
                [2] = "行李",
                [3] = "老外",
                [4] = "公交内部员工",
                [5] = "小偷"
            };
            Iterator iterator = new ConcreteIterator(concreteAggregate);
            iterator.First();
            while (!iterator.IsDone())
            {
                Console.WriteLine($"{iterator.CurrentItem()}请买车票");
                iterator.Next();
            }

            Console.Read();
        }
    }
}
