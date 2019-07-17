using System;
using System.Collections.Generic;
using System.Text;

namespace InterpreterPattern_解释器模式_
{
    class NonterminalExpression:AbstractExpression
    {
        public override void Interpret(Context context)
        {
            Console.WriteLine("非终端解释器");
        }
    }
}
