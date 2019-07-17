using System;
using System.Collections.Generic;
using System.Text;

namespace InterpreterPattern_解释器模式_
{
    abstract class AbstractExpression
    {
        public abstract void Interpret(Context context);
    }
}
