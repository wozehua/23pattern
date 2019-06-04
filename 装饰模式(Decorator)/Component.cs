/*
*命名空间: 装饰模式_Decorator_
*类    名：Component
*创 建 人：蔡泽华
*创建时间：2018/1/7 20:42:08
*/

namespace 装饰模式_Decorator_
{
    /// <summary>
    /// 抽象构件（Component）角色：给出一个抽象接口，
    /// 以规范准备接收附加责任的对象。
    /// </summary>
    public abstract class Component
    {
        public abstract void Operation();
    }
}
