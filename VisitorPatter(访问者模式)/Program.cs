using System;
using VisitorPatter_访问者模式_.Example;

namespace VisitorPatter_访问者模式_
{
    /// <summary>
    /// 访问者模式：表示一个作用于某个对象结构中的各元素的操作。它使你可以在不改变各元素的类
    /// 的前提下定义作用于这些元素的新操作。
    /// 访问者模式适用于数据结构相对稳定的系统。
    /// 它把数据结构和作用于结构智商的操作之间的耦合解脱开，使得操作集合可以相对自由地演化。
    /// 访问者模式的目的 是要把处理从数据结构分离出来。
    /// 优点：增加新操作很容易
    /// 缺点：增加新的数据结构变得困难
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            ObjectStructure ob = new ObjectStructure();
            ob.Attach(new Man());
            ob.Attach(new Woman());

            Success s = new Success();
            ob.Display(s);
            Console.Read();
        }
    }
}
