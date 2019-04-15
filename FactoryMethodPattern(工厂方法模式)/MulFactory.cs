
namespace FactoryMethodPattern_工厂方法模式_
{
    class MulFactory:IFactory
    {
        public Operation CreateOperation()
        {
            return new OperationMul();
        }
    }
}
