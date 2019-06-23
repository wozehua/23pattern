using System;

namespace StatePattern_状态模式_
{
    /// <summary>
    /// 在状态模式中 ，类行为是基于它的状态改变的。行为型模式
    /// 在传统该模式中，我们创建表示各种状态的对象和一个行为随着状态对象改变而改变的context对象。
    ///状态模式主要解决的是当控制一个对象状态转换的条件表达式过于复杂的时的情况，把状态的判断逻辑转移到表示不同状态的
    /// 一系列类当中 ,可以把复杂的判断逻辑简化。如果这个状态判断很简单就没有必要用 状态模式了。
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //初始化
            var work = new Work {Hour = 9};
            work.WriteProgram();
            work.Hour = 10;
            work.WriteProgram();
            work.Hour = 12;
            work.WriteProgram();
            work.Hour = 13;
            work.WriteProgram();
            work.Hour = 14;
            work.WriteProgram();
            work.Hour = 17;
            work.WriteProgram();
            work.TaskFinished = false;
            work.Hour = 19;
            work.WriteProgram();
            work.Hour = 22;
            work.WriteProgram();
            Console.Read();
        }
    }
}
