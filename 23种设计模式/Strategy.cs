/*
*命名空间: _23种设计模式
*类    名：Strategy
*创 建 人：蔡泽华
*创建时间：2017/12/31 22:45:51
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23种设计模式
{
    /// <summary>
    /// 抽象算法类 --策略模式
    /// </summary>
    public abstract class Strategy
    {
        //算法方法
        public abstract void AlgorithmInterface();
    }
}
