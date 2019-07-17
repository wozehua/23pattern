using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorPatter_访问者模式_.Example
{
    class Man:Person
    {
        /// <summary>
        /// 客户程序中将具体状态作为参数传递给 男人类完成一次分派
        /// 男人类调用作为参数的具体状态中的GetManConclusion 男人反应 同时将自己this
        /// 作为参数传递进去,这便完成了第二次分派：所以叫做双分派技术
        /// </summary>
        /// <param name="action"></param>
        public override void Accept(Action action)
        {
            //双分派技术
            action.GetManConclusion(this);
        }
    }
}
