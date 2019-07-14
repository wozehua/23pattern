using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorPattern_中介者模式_
{
    /// <summary>
    ///缺点就是：由于ConcreteMediator控制了集中化，所以把交互复杂性变为了中介者的复杂性
    /// 如果每次都要增加一个新的具体的Colleague这样这个具体的中介者就会变得很复杂。
    /// </summary>
    public class ConcreteMediator:Mediator
    {
        private ConcreteColleague1 _colleague1;
        public ConcreteColleague1 Colleague1
        {
            set => _colleague1 = value;
        }
        private ConcreteColleague2 _colleague2;
        public ConcreteColleague2 Colleague2
        {
            set => _colleague2 = value;
        }
        public override void Send(string message, Colleague colleague)
        {
            if (colleague == _colleague1)
            {
                _colleague1.Notify(message);
            }
            else
            {
                _colleague2.Notify(message);
            }
        }
    }
}
