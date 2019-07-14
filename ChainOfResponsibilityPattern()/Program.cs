using System;
using ChainOfResponsibilityPattern__职责链模式_.Example;

namespace ChainOfResponsibilityPattern__职责链模式_
{
    /// <summary>
    /// 职责链模式：使多个对象都有机会处理请求，从而避免请求的发送者和接收者之间的耦合关系，将这个对象连成一条链
    /// 并沿着这条链传递该请求，直到有一个对象处理它为止。
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            #region 常规模式
            //Handler h1 = new ConcretenHandler1();
            //Handler h2 = new ConcreteHandler2();
            //Handler h3 = new ConcreteHandler3();
            //h1.SetSuccessor(h2);
            //h2.SetSuccessor(h3);
            //int[] request3 = { 2, 5, 14, 22, 18, 3, 27, 20 };
            //foreach (var request in request3)
            //{
            //    h1.HandlerRequest(request);
            //} 
            #endregion

            #region MyRegion

            CommonManager manager = new CommonManager("经理");
            Majordomo majordomo = new Majordomo("总监");
            GeneralManager generalManager = new GeneralManager("总经理");
            manager.SetSuperior(majordomo);
            majordomo.SetSuperior(generalManager);
            Request request = new Request();
            request.RequestType = "请假";
            request.RequstContent = "asdfasd";
            request.Number = 500;
            manager.ProcessRequst(request);

            #endregion
            Console.Read();
        }
    }
}
