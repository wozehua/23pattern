using System;

namespace 适配器模式_AdapterPattern_.ObjectAdapter
{
    /// <summary>
    ///Target 客户所期待的接口，目标可以是具体的或抽象的类，也可以是接口
    /// </summary>
    class Target
    {
        public virtual void Request()
        {
            Console.WriteLine("普通请求！");
        }
    }
}
