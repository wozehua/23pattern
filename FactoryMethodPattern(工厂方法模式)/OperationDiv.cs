
using System;

namespace FactoryMethodPattern_工厂方法模式_
{
    class OperationDiv:Operation
    {
        public override double GetResult()
        {
            double result = 0;
            if (NumberB==0)
            {
                throw new Exception("除数不能为0");
            }
            result = NumberA / NumberB;
            return result;
        }
    }
}
