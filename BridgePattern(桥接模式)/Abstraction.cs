namespace BridgePattern_桥接模式_
{
    class Abstraction
    {
        protected Implementor Implementor;

        public  void SetImplementor(Implementor implementor)
        {
            Implementor = implementor;
        }

        public virtual void Operation()
        {
            Implementor.Operation();
        }
    }
}
