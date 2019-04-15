

namespace FactoryMethodPattern_工厂方法模式_
{
    class AddFactory:IFactory
    {
        public Operation CreateOperation()
        {
            return new OperationAdd();
        }
    }
}
