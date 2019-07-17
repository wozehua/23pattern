using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorPatter_访问者模式_.Example
{
    abstract class Action
    {
        public abstract void GetManConclusion(Man man);
        public abstract void GetWomenManConclusion(Woman man);
    }
}
