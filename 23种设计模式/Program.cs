using System;

namespace _23种设计模式
{
    class Program
    {
        static void Main()
        {
            //由于实例化不同的策略,所以最终在调用Context.ContextInterface();
            //时,所获得的结果不尽相同
            var context = new Context(new ConcreteStrategyA());
            context.ContextInterface();
            context = new Context(new ConcreteStrategyB());
            context.ContextInterface();
            context = new Context(new ConcreteStrategyC());
            context.ContextInterface();
            Console.Read();
        }
    }
}
