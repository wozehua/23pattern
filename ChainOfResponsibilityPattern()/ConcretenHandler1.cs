using System;

namespace ChainOfResponsibilityPattern__职责链模式_
{
    public class ConcretenHandler1:Handler
    {
        public override void HandlerRequest(int request)
        {
            if (request >= 0 & request < 10)
            {
                Console.WriteLine($"{this.GetType().Name}处理请求{request}");
            }
            else
            {
                handler?.HandlerRequest(request);
            }
        }

    }
}
