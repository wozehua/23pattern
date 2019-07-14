using System;
using MediatorPattern_中介者模式_.Example;

namespace MediatorPattern_中介者模式_
{
    /// <summary>
    /// 中介者模式：用一个中介对象来封装一系列的对象交互，中介者使各个对象不需要显示地相互引用，从而
    /// 使其耦合松散，而且可以独立地改变他们之间的交互。
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            #region 例子
            //ConcreteMediator concreteMediator = new ConcreteMediator();
            ////让两个同事认识中介者对象
            //ConcreteColleague1 concreteColleague1 = new ConcreteColleague1(concreteMediator);
            //ConcreteColleague2 concreteColleague2 = new ConcreteColleague2(concreteMediator);
            ////让中介者认识各个具体的对象
            //concreteMediator.Colleague1 = concreteColleague1;
            //concreteMediator.Colleague2 = concreteColleague2;
            ////具体同事类对象的发送信息都是通过中介者转发
            ////具体中介者里面的Send控制者这个转发是发给哪一个具体的对象执行。
            //concreteColleague1.Send("吃过饭了吗？");
            //concreteColleague2.Send("没有呢，你打算请客？"); 
            #endregion

            #region MyRegion
            UnitNationsMediator u = new UnitNationsMediator();
            USA uSA = new USA(u);
            Iraq iraq = new Iraq(u);
            u.Iraq = iraq;
            u.USA = uSA;
            uSA.Declare("美国的声明");
            iraq.Declare("伊拉克的声明");


            #endregion
            Console.Read();
        }
    }
}
