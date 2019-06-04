﻿using System;
using 适配器模式_AdapterPattern_.ClassAdapter;
using Adapter = 适配器模式_AdapterPattern_.ObjectAdapter.Adapter;

namespace 适配器模式_AdapterPattern_
{
    /// <summary>
    /// 适配器模式（Adapter Pattern）
    /// 将一个类的接口转换成客户希望的另外一个接口。Adapter模式使得原本由于接口不兼容而不能
    /// 一起工作的那些类可以一起工作。
    /// 在软件开发中，也就是系统的数据和行为都正确，但接口不符时，我们应该考虑用适配器，目的是使控制范围之外的一个原有
    /// 对象与某个接口匹配。适配器模式主要应用于希望复用一些现存的类，但是接口又与复用环境要求不一致的情况，
    /// 在GoF的设计模式中，对适配器模式讲了两种类型，类适配器模式和对象适配器模式，由于类适配器模式通过多重继承对一个接口与另一个接口进行匹配，
    /// .net 中DataAdapter 就是采用适配器模式
    /// https://www.cnblogs.com/zhili/p/AdapterPattern.html
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            #region 对象适配器实现
            var target = new Adapter();
            target.Request();
            #endregion

            #region 类适配器实现

            IThreeHole threeHole = new ClassAdapter.Adapter();
            threeHole.Request();

            #endregion
            Console.Read();
        }
    }
}
