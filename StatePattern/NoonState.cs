using System;

namespace StatePattern_状态模式_
{
    public class NoonState:State
    {
        public override void WriteProgram(Work work)
        {
            if (work.Hour<13)
            {
                Console.WriteLine($"当前时间：{work.Hour}点 饿了，午饭；犯困，午休。");
            }
            else
            {
                work.SetState(new AfternoonState());
                work.WriteProgram();
            }
        }
    }
}
