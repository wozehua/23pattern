using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern_状态模式_
{
    public class EveningState:State
    {
        public override void WriteProgram(Work work)
        {
            if (work.TaskFinished)
            {
                work.SetState(new RestState());
                work.WriteProgram();
            }
            else
            {
                if (work.Hour < 21)
                {
                    Console.WriteLine($"当前时间：{work.Hour}点 加班哦，疲累之极");
                }
                else
                {
                    work.SetState(new SleepingState());
                    work.WriteProgram();
                }
            }
        }
    }
}
