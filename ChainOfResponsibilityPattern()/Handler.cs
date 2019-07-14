namespace ChainOfResponsibilityPattern__职责链模式_
{
    public abstract class Handler
    {
        protected Handler handler;

        /// <summary>
        /// 设置继任者
        /// </summary>
        /// <param name="handler"></param>
        public void SetSuccessor(Handler handler)
        {
            this.handler = handler;
        }

        public abstract void HandlerRequest(int request);
    }
}
