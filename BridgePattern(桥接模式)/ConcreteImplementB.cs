using System;

namespace BridgePattern_桥接模式_
{
    class ConcreteImplementB:Implementor
    {
        public override void Operation()
        {
            Console.WriteLine("具体实现B的方法执行");
        }
    }
}
