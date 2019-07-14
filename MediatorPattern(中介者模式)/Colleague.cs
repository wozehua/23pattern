using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorPattern_中介者模式_
{
    public class Colleague
    {
        protected Mediator mediator;
        /// <summary>
        /// 构造方法得到中介者对象
        /// </summary>
        /// <param name="mediator"></param>
        public Colleague(Mediator mediator)
        {
            this.mediator = mediator;
        }
    }
}
