namespace BridgePattern_桥接模式_
{
    class RefinedAbstraction:Abstraction
    {
        public override void Operation()
        {
            Implementor.Operation();
        }
    }
}
