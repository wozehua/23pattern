using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorPattern_中介者模式_.Example
{
    class USA:Country
    {
        public USA(UnitNations unitNations) : base(unitNations)
        {
        }

        public void Declare(string message)
        {
            unitNations.Declare(message, this);
        }

        public void GetMessage(string message)
        {
            Console.WriteLine($"美国获取对方信息:{message}");
        }
    }
}
