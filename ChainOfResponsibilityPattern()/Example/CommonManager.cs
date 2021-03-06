﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibilityPattern__职责链模式_.Example
{
    class CommonManager:Manager
    {
        public CommonManager(string name) : base(name)
        {
        }

        public override void ProcessRequst(Request request)
        {
            if (request.RequestType == "请假" && request.Number <= 2)
            {
                Console.WriteLine($"{name}:{request.RequstContent}数量{request.Number}被批准");
            }
            else
            {
                manager?.ProcessRequst(request);
            }
        }
    }
}
