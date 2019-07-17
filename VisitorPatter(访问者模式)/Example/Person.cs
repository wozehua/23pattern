using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorPatter_访问者模式_.Example
{
    abstract class Person
    {
        public abstract void Accept(Action action);
    }
}
