using System;

namespace StatePattern_状态模式_
{
    public class RestState:State
    {
        public override void WriteProgram(Work work)
        {
            Console.WriteLine($"当前时间：{work.Hour}点下班回家了");
        }
    }
}
