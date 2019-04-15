
namespace FactoryMethodPattern_工厂方法模式_
{
    class OperationMul:Operation
    {
        /// <summary>
        /// 乘法类
        /// </summary>
        /// <returns></returns>
        public override double GetResult()
        {
            double result = 0;
            result = NumberA * NumberB;
            return result;
        }
    }
}
