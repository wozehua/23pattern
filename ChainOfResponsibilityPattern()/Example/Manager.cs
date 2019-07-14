using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibilityPattern__职责链模式_.Example
{
    public abstract class Manager
    {
        protected string name;

        protected Manager manager;

        public Manager(string name)
        {
            this.name = name;
        }

        public void SetSuperior(Manager manager)
        {
            this.manager = manager;
        }

        public abstract void ProcessRequst(Request request);

    }
}
