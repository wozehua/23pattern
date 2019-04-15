using System;

namespace FactoryMethodPattern_工厂方法模式_
{
    class Program
    {
        //对齐代码 快捷键 CTRL +K+d  配合ctrl+A使用 全局对齐代码
        //如果在试图页的话 是 ctrl +k+s  配合ctrl+A 使用全局对齐代码
        //Ctrl+j/Ctrl+K,L列出成员
        //CTRL+SHIFT + 空格/ Ctrl+K,P参数信息 要在方法的括号内快捷键才有效
        //Ctrl+k,i快速信息 可以快速查看方法的信息
        //Ctrl+l删除光标所在行
        //Ctrl+enter 在当前行上方插入空行
        //Ctrl+Shift 在光标行的下方插入空行
        static void Main(string[] args)
        {
            //工厂方法模式（Factory Method Pattern）定义一个用于创建对象的接口,
            //让子类决定实例化哪一个类,工厂方法是一个类的实例化延时到其子类。
            IFactory createAddFactory = new AddFactory();
            Operation oper = createAddFactory.CreateOperation();
            oper.NumberA = 9;
            oper.NumberB = 1;
            Console.WriteLine();
            Console.WriteLine($"工厂模式加法{oper.GetResult()}");
            IFactory createSubFactory = new SubFactory();
            Operation subOper = createSubFactory.CreateOperation();
            subOper.NumberB = 1;
            Console.WriteLine($"工厂模式减法{subOper.GetResult()}");
            Console.Read();








        }
    }
}
