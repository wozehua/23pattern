using System;
using System.Collections.Generic;
using System.Text;

namespace FlyWeight_享元模式_
{
    class UnsharedConcreteFlyWeight:FlyWeight
    {
        public override void Operation(int extrinsicstate)
        {
            Console.WriteLine($"不共享的具体FlyWeight{extrinsicstate}");
        }
    }
}
