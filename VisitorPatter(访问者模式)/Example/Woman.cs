using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorPatter_访问者模式_.Example
{
    class Woman:Person
    {
        public override void Accept(Action action)
        {
            //双分派技术
            action.GetWomenManConclusion(this);
        }
    }
}
