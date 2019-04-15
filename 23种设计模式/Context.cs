/*
*命名空间: _23种设计模式
*类    名：Context
*创 建 人：蔡泽华
*创建时间：2017/12/31 22:52:07
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23种设计模式
{

    public class Context
    {
        private readonly Strategy _strategy;
        /// <summary>
        /// 初始化时,传入具体的策略对象
        /// </summary>
        /// <param name="strategy"></param>
        public Context(Strategy strategy)
        {
            _strategy = strategy;
        }
        /// <summary>
        /// 根据具体的策略对象，调用其算法的方法
        /// </summary>
        public void ContextInterface()
        {
            _strategy.AlgorithmInterface();

        }

    }
}
