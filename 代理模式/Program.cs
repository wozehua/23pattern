using System;

namespace 代理模式
{
    class Program
    {
        static void Main()
        {
            var jiaojioa = new SchoolGirl {Name = "jiaojioa"};
            var proxy = new Proxy(jiaojioa);
            proxy.GiveChocolate();
            proxy.GiveDolls();
            proxy.GiveFlowers();
            Console.Read();
        }
    }
}
