using System;
using System.Collections.Generic;
using System.Text;

namespace 适配器模式_AdapterPattern_.ObjectAdapter
{
    /// <summary>
    /// 需要适配的类
    /// </summary>
    class Adaptee
    {
        public void SpecificRequest()
        {
            Console.WriteLine("特殊请求");
        }
    }
}
