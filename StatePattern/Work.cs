namespace StatePattern_状态模式_
{
    public class Work
    {
        private State current { get; set; }

        /// <summary>
        /// 初始化工作状态
        /// </summary>
        public Work()
        {
            current =new ForenoonState() ; //new State();
        }

        public double Hour { get; set; }
        public bool TaskFinished { get; set; }

        public void SetState(State s)
        {
            current = s;
        }

        public void WriteProgram()
        {
            current.WriteProgram(this);
        }

    }
}
