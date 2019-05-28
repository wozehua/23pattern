/*
*命名空间: 装饰模式_Decorator_
*类    名：Decorator
*创 建 人：蔡泽华
*创建时间：2018/1/7 20:45:12
*/

namespace 装饰模式_Decorator_
{

    public abstract class Decorator:Component
    {
        protected Component Component;

        public void SetComponent(Component component)
        {
            Component = component;
        }
        public override void Operation()
        {
            Component?.Operation();
        }
    }
}
