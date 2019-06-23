namespace AbstractFactoryPattern_抽象工厂模式_
{
    public class FuzhouFactory:AbstractFactory
    {
        public override YaBo CreateYaBo()
        {
            return new FuZhouYaBo();
        }

        public override YaJia CreateYaJia()
        {
            return new FuZhouYaJia();
        }
    }
}
