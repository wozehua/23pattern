using System;

namespace BridgePattern_桥接模式_
{
    class ConcreteImplementorA:Implementor
    {
        public override void Operation()
        {
            Console.WriteLine("具体实现A的方法执行");
        }
    }
}
