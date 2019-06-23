using System;

namespace StatePattern_状态模式_
{
    public class SleepingState:State
    {
        public override void WriteProgram(Work work)
        {
            Console.WriteLine($"当前时间：{work.Hour}点不行了，睡着了。");
        }
    }
}
