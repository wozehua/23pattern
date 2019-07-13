using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern_命令模式_.Example
{
    public class Barbecuer
    {
        public void BakeMutton()
        {
            Console.WriteLine("烤羊肉串");
        }

        public void BakeChickenWing()
        {
            Console.WriteLine("烤鸡翅");
        }
    }
}
