namespace CommandPattern_命令模式_
{
    class ConcreteCommand:Command
    {
        public override void Execute()
        {
            Receiver.Action();
        }

        public ConcreteCommand(Receiver receiver) : base(receiver)
        {
        }
    }
}
