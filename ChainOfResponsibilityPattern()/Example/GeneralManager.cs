using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibilityPattern__职责链模式_.Example
{
    class GeneralManager : Manager
    {
        public GeneralManager(string name) : base(name)
        {
        }

        public override void ProcessRequst(Request request)
        {
            if (request.RequestType == "请假")
            {
                Console.WriteLine($"{name}:{request.RequstContent}数量{request.Number}被批准");
            }
            else if (request.RequestType == "加薪" && request.Number <= 500)
            {
                Console.WriteLine($"{name}:{request.RequstContent}数量{request.Number}被批准");
            }
            else if (request.RequestType == "加薪" && request.Number > 500)
            {
                Console.WriteLine($"{name}:{request.RequstContent}数量{request.Number}再说");
            }
        }
    }
}
