using System;
using System.Collections.Generic;
using System.Text;

namespace 适配器模式_AdapterPattern_.ClassAdapter
{
    /// <summary>
    /// 客户端想要把2个孔的插头转换为3个孔的插头。
    /// </summary>
    public interface IThreeHole
    {
        void Request();
    }
}
