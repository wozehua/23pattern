/*
*命名空间: _23种设计模式
*类    名：ConcreteStrategyA
*创 建 人：蔡泽华
*创建时间：2017/12/31 22:48:29
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23种设计模式
{

    /// <summary>
    /// 封装了具体的算法或行为,继承于Strategy
    /// </summary>
    public class ConcreteStrategyA : Strategy
    {
        /// <summary>
        /// 算法A的实现方式
        /// </summary>
        public override void AlgorithmInterface()
        {
            Console.WriteLine("实现算法A");
        }
    }

    /// <summary>
    /// 算法B的实现方式
    /// </summary>
    public class ConcreteStrategyB : Strategy
    {
        public override void AlgorithmInterface()
        {
            Console.WriteLine("实现算法B");
        }
    }
    /// <summary>
    /// 算法C的实现方式
    /// </summary>
    public class ConcreteStrategyC : Strategy
    {
        public override void AlgorithmInterface()
        {
            Console.WriteLine("实现算法C");
        }
    }

}
