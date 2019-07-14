using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibilityPattern__职责链模式_
{
    public class ConcreteHandler3:Handler
    {
        public override void HandlerRequest(int request)
        {
            if (request >= 20 && request < 30)
            {
                Console.WriteLine($"{GetType().Name}处理请求{request}");
            }
            else
            {
                handler?.HandlerRequest(request);

            }
        }
    }
}
