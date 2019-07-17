using System;
using System.Collections.Generic;
using System.Text;

namespace InterpreterPattern_解释器模式_
{
    class TerminalExpression:AbstractExpression
    {
        public override void Interpret(Context context)
        {
            Console.WriteLine("终端解释器");
        }
    }
}
