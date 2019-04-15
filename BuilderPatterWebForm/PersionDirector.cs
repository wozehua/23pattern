using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatterWebForm
{
    /// <summary>
    /// 建造者模式中很重要的一个类，指挥者(Director)
    /// </summary>
    class PersionDirector
    {
        private PersonBuilder pb;

        /// <summary>
        /// 用户告诉指挥者需要什么样的小人
        /// </summary>
        /// <param name="personBuilder"></param>
        public PersionDirector(PersonBuilder personBuilder)
        {
            pb = personBuilder;
        }

        public void CreatePerson()
        {
            pb.BuildHead();
            pb.BuildBody();
            pb.BuildLegLeft();
            pb.BuildLegRight();
            pb.BuildArmLeft();
            pb.BuildArmRight();
        }
    }
}
