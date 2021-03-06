﻿/*
*命名空间: 装饰模式_Decorator_
*类    名：ConcreteDecoratorA
*创 建 人：蔡泽华
*创建时间：2018/1/7 20:50:02
*/
using System;


namespace 装饰模式_Decorator_
{

    public  class ConcreteDecoratorA:Decorator
    {
        /// <summary>
        /// 本类的独有功能,以区别于ConcreteDecoratorB
        /// </summary>
        public  string AddedState;
        public override void Operation()
        {
            //首先运行的是Component的Opeartion(),再执行本类的功能，如AddedState,相当于对原Component 进行装饰。
            base.Operation();
            AddedState = "New State";
            Console.WriteLine(AddedState+"具体装饰对象A的操作");
        }
    }


  
}
