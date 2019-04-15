using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatterWebForm
{
    class PersonThinBuilder:PersonBuilder
    {
        public PersonThinBuilder(Graphics graphics, Pen pen) : base(graphics, pen)
        {
        }

        public override void BuildHead()
        {
            graphics.DrawEllipse(pen, 50, 20, 30, 30);
        }

        public override void BuildBody()
        {
            graphics.DrawRectangle(pen, 60, 50, 10, 50);
        }

        public override void BuildArmLeft()
        {
            graphics.DrawLine(pen, 60, 50, 40, 100);
        }

        public override void BuildArmRight()
        {
            graphics.DrawLine(pen, 70, 50, 90, 100);
        }

        public override void BuildLegLeft()
        {
            graphics.DrawLine(pen, 60, 100, 45, 150);
        }

        public override void BuildLegRight()
        {
            graphics.DrawLine(pen, 70, 100, 85, 150);
        }
    }
}
