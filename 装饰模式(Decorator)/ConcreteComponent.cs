/*
*命名空间: 装饰模式_Decorator_
*类    名：ConcreteComponent
*创 建 人：蔡泽华
*创建时间：2018/1/7 20:43:50
*/

using System;

namespace 装饰模式_Decorator_
{

    public class ConcreteComponent:Component
    {
        public override void Operation()
        {
            Console.WriteLine("具体操作对象");
        }
    }
}
