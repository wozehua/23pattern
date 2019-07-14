using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern_命令模式_.Example
{
    public abstract class Command
    {
        protected Barbecuer Barbecuer;

        public Command(Barbecuer barbecuer)
        {
            Barbecuer = barbecuer;
        }

        public abstract void ExcuteCommand();
    }
}
