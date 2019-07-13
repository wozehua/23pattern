using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern_命令模式_.Example
{
    public class BakeMuttonCommand:Command
    {
        public BakeMuttonCommand(Barbecuer barbecuer) : base(barbecuer)
        {
        }

        public override void ExcuteCommand()
        {
            Barbecuer.BakeMutton();
        }
    }
}
