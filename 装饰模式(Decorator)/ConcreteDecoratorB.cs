using System;

namespace 装饰模式_Decorator_
{
    public class ConcreteDecoratorB : Decorator
    {
        //首先运行基类Component的Operation() ,在执行本类的功能，如AddBehavior(),相当于对原Component进行了装饰
        public override void Operation()
        {
            base.Operation();
            AddedBehavior();
            Console.WriteLine("具体装饰对象B的操作");

        }
        /// <summary>
        /// 本类独有的方法,以区别于ComponentDecoratorA
        /// </summary>
        public void AddedBehavior()
        {
            Console.WriteLine("ConcreteDecoratorB");
        }
    }
}
