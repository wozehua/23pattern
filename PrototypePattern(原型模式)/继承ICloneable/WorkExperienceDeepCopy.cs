using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern_原型模式_.继承ICloneable
{
    class WorkExperienceDeepCopy:ICloneable
    {
        public DateTime WorkDate { get; set; }

        public string  Company { get; set; }
        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
