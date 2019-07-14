using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibilityPattern__职责链模式_
{
    public class ConcreteHandler2:Handler
    {
        public override void HandlerRequest(int request)
        {
            if (request >= 10 && request < 20)
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
