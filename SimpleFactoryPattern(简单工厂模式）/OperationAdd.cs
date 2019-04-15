using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryPattern_简单工厂模式_
{
    class OperationAdd:Operation
    {
        /// <summary>
        /// 加法类
        /// </summary>
        /// <returns></returns>
        public override double GetResult()
        {
            double result = 0;
            result = NumberA + NumberB;
            return result;
        }
    }
}
