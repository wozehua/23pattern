using System;
namespace PrototypePattern_原型模式_
{
    class Program
    {
        /// <summary>
        /// 原型模式，用原型实例指定创建对象的种类，并通过拷贝这些原型创建新的对象
        /// 原型模式其实就是从一个对象在创建另外一个可定制的对象，而且不需知道任何创建的细节
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            ConcretePrototypeA cpa = new ConcretePrototypeA("I");
            ConcretePrototypeA cpaShallCopy = (ConcretePrototypeA)cpa.Clone();
            Console.WriteLine("Cloned:{0}",cpaShallCopy.Id);
            Console.Read();

            #region IConeable说明
            //.Net 在System 命名空间中提供了IConeable 接口，我们实现这个接口就可以完成原型模式了


            #endregion
        }
    }
}
