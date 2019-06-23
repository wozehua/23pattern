using System;

namespace StatePattern_状态模式_
{
    public class ForenoonState:State
    {
        public override void WriteProgram(Work work)
        {
            if (work.Hour < 12)
            {
                Console.WriteLine($"当前时间:{work.Hour}点 上午工作，精神百倍");
            }
            else
            {
                //转入下一个工作状态
                work.SetState(new NoonState());
                work.WriteProgram();
            }
        }
    }
}
