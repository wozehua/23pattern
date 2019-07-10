using System;

namespace SingletonPattern_单例模式_
{
    /// <summary>
    /// 单例模式：保证一个类仅有一个实例，并提供一个访问他全局访问点。
    /// 通常我们可以让一个全局变量使得一个对象被访问，但它不能防止你实例化多个对象。
    /// 一个最好的方法就是，让类自身负责保存它唯一实例。这个类可以保证没有其他实例可以被创建，并且它可以提供
    /// 一个访问该实例的方法。
    /// 单例模式因为Singleton类封转它的唯一实例，这样他可以严格控制客户怎样访问它以及何时访问它，简单地说就是唯一实例的受控访问。
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var s1 = Singleton.GetSingleton();
            var s2 = Singleton.GetSingleton();
            if(s1==s2) Console.WriteLine("两个对象是相同的实例");
            Console.Read();
        }
    }
}
