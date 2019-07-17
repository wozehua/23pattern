using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorPatter_访问者模式_.Example
{
    class Success:Action
    {
        public override void GetManConclusion(Man man)
        {
            Console.WriteLine($"{man.GetType().Name}{this.GetType().Name}时，背后多半有一个伟大的女人");
        }

        public override void GetWomenManConclusion(Woman man)
        {
            Console.WriteLine($"{man.GetType().Name}{GetType().Name}时,背后大多有一个成功的男人");
        }
    }
}
