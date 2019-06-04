using System;
using System.Collections.Generic;
using System.Text;

namespace 适配器模式_AdapterPattern_.ClassAdapter
{
    public class Adapter:TwoHole,IThreeHole
    {
        public void Request()
        {
            base.SpecificRequest();
        }

    }
}
