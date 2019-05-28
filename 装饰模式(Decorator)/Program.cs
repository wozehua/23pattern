using System;

namespace 装饰模式_Decorator_
{
    class Program
    {
        static void Main(string[] args)
        {
            var c = new ConcreteComponent();
            var d1 = new ConcreteDecoratorA();
            var d2 = new ConcreteDecoratorB();
            d1.SetComponent(c);
            d2.SetComponent(d1);
            d2.Operation();
            Console.Read();
        }
    }
}
