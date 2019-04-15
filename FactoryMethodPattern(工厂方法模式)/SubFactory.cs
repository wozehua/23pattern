
namespace FactoryMethodPattern_工厂方法模式_
{
    class SubFactory : IFactory
    {
        public Operation CreateOperation()
        {
            return new OperationSub();
        }
    }
}
