
namespace FactoryMethodPattern_工厂方法模式_
{
    class DivFactory:IFactory
    {
        public Operation CreateOperation()
        {
            return new OperationDiv();
        }

    }
}
