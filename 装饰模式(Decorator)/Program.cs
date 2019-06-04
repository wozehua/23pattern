using System;

namespace 装饰模式_Decorator_
{
    class Program
    {
        /// <summary>
        /// 定义：装饰模式，动态地给一个对象添加一些额外的职责，就增加功能来说，装饰模式比生成子类更为灵活。
        /// 多组合少继承：合成/聚合原则
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            #region 模式简化
            //模式简化：
            //如果只有一个ConcreteComponent类而没有抽象的Component类，那么Decorator类可以是ConcreteComponent的一个子类。
            //同样的道理 如果只有一个ConcreteDecorator 类，那就没有必要建立一个单独的Decorator类，而可以把Decorator和
            //ConcreteDecorator的责任合并成一个类。
            #endregion

            #region 角色组成
            //抽象构件(Component)角色：给出一个抽象接口，以规范准备接受附加责任的对象。
            //具体构件(ConcreteComponent)角色：定义一个将要接收附加责任的类。
            //装饰角色(Decorator):持有一个构件(Component)对象的实例，并定义一个于抽象构件接口一致的接口。
            //具体装饰角色(ConcreteDecorator):负责给构件对象"贴上"附加的责任。
            

            #endregion
            var c = new ConcreteComponent();
            var d1 = new ConcreteDecoratorA();
            var d2 = new ConcreteDecoratorB();
            d1.SetComponent(c);
            d2.SetComponent(d1);
            d2.Operation();
            Console.Read();
        }
    }
}
