using System;

namespace AbstractFactoryPattern_抽象工厂模式_
{
    /// <summary>
    /// 抽象工厂模式 是围绕一个超级工厂创建其他工厂该工厂又称为其他工厂
    /// 的工厂。提供了一种创建对象的最佳方式。
    /// 抽象工厂模式，提供一个创建一系列相关或相互依赖对象的接口，而无需指定他们呢具体的类。
    /// 抽象工厂主要是一个产品族里面有多个产品的形式，工厂模式则是一个产品就是一个工厂,抽象工厂则是一个工厂有多个产品。
    ///  </summary>
    class Program
    {
        static void Main(string[] args)
        {
            AbstractFactory abstractFactory = new FuzhouFactory();
            abstractFactory.CreateYaBo().Print();
            abstractFactory.CreateYaJia().Print();
            Console.Read();
        }
    }
}
