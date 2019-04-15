using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatterWebForm
{
    abstract class PersonBuilder
    {
        protected Graphics graphics;
        protected Pen pen;

        public PersonBuilder( Graphics graphics,Pen pen)
        {
            this.graphics = graphics;
            this.pen = pen;
        }

        public abstract void BuildHead();

        public abstract void BuildBody();
        public abstract void BuildArmLeft();

        public abstract void BuildArmRight();

        public abstract void BuildLegLeft();

        public abstract void BuildLegRight();







    }
}
