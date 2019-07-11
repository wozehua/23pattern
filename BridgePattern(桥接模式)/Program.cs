using System;

namespace BridgePattern_桥接模式_
{
    /// <summary>
    /// 桥接模式：将抽象部分与它的实现部分分离，是他们都可以独立地变化。
    /// 什么叫抽象与它的实现分离，这并不是说，让抽象类与其派生类分离，因为这没有任何意义，实现指的是抽象类和它的派生类用来
    /// 实现自己的对象。
    /// 桥接模式的核心意图就是把这些实现独立出来，让他们各自地变化。这就使得每种实现的变化不会影响其他实现。
    /// 从而达到应对变化的目的。
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Abstraction abstraction = new RefinedAbstraction();
            abstraction.SetImplementor(new ConcreteImplementorA());
            abstraction.Operation();
            abstraction.SetImplementor(new ConcreteImplementB());
            abstraction.Operation();
            Console.Read();

        }
    }
}

#region 合成/聚合复用原则
//尽量使用合成/聚合，尽量不要使用类继承
//聚合表示一种弱的‘拥有’关系，体现的是A对象可以包含B对象，但B对象不是A对象的一部分。
//合成则是一种强的‘拥有’关系，体现了严格的部分和整体的关系，部分和整体的生命周期一样。
//优先使用对象的合成/聚合将有助于你保持每个类被封装，并被集中在单个任务上。这样类和类继承层次会保持较小的规模
//并且不太可能增长为不可控制的庞然大物。
#endregion
#region 说明
//对象的继承关系是在编译时就定义好了，所以无法在运行时改变从父类继承的实现
//子类的实现与它的父类有非常紧密的依赖关系，以至于父类实现中的任何变化必然会导致
//子类发生变化。当你需要复用子类时，如果继承下来的实现不适合解决新的问题，则父类必须重写或
//被其他更适合的类替换。这种依赖关系限制了灵活性并最终限制了复用性。


#endregion