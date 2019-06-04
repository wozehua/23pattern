using System;

namespace 适配器模式_AdapterPattern_.ClassAdapter
{
    public abstract class TwoHole
    {
        public void SpecificRequest()
        {
            Console.WriteLine("我是两个孔的插头");
        }
    }
}
