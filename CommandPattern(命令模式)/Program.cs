﻿using System;
using CommandPattern_命令模式_.Example;

namespace CommandPattern_命令模式_
{
    /// <summary>
    /// 命令模式：将一个请求封装为一个对象，从而使你可用不同的请求对客户进行参数化，
    /// 对请求排队或记录请求日志，以及支持可撤销的操作。
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            #region 命令模式
            //Receiver receiver = new Receiver();
            //Command command = new ConcreteCommand(receiver);
            //Invoker invoker = new Invoker();
            //invoker.SetCommand(command);
            //invoker.ExecuteCommand(); 
            #endregion

            #region 列子

            //Barbecuer barbecuer = new Barbecuer();
            //Command bakeMuttonCommand1 = new BakeMuttonCommand(barbecuer);


            #endregion
            Console.Read();
        }
    }
}
