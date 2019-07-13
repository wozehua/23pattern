namespace CommandPattern_命令模式_
{
    abstract class Command
    {
        protected Receiver Receiver;

        protected Command(Receiver receiver)
        {
            Receiver = receiver;
        }
        public abstract void Execute();
    }
}
