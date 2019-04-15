
namespace FactoryMethodPattern_工厂方法模式_
{
    class OperationSub:Operation
    {
        /// <summary>
        /// 减法类
        /// </summary>
        /// <returns></returns>
        public override double GetResult()
        {
            double result = 0;
            result = NumberA - NumberB;
            return result;
        }

    }
}
