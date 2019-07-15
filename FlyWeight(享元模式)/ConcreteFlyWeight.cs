using System;
using System.Collections.Generic;
using System.Text;

namespace FlyWeight_享元模式_
{
    class ConcreteFlyWeight:FlyWeight
    {
        public override void Operation(int extrinsicstate)
        {
            Console.WriteLine($"具体FlyWeight{extrinsicstate}");
        }
    }
}
