using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorPattern_中介者模式_
{
    public abstract class Mediator
    {
        /// <summary>
        /// 定义一个抽象的发送消息方法，得到同事对象和发送消息。
        /// </summary>
        /// <param name="message"></param>
        /// <param name="colleague"></param>
        public abstract void Send(string message, Colleague colleague);
    }
}
