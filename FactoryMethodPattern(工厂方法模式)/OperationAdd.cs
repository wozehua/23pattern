
namespace FactoryMethodPattern_工厂方法模式_
{
    class OperationAdd:Operation
    {
        /// <summary>
        /// 加法类
        /// </summary>
        /// <returns></returns>
        public override double GetResult()
        {
            double result = 0;
            result = NumberA + NumberB;
            return result;
        }
    }
}
