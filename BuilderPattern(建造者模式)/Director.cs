using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern_建造者模式_
{
    class Director
    {
        public void Construct(Builder bd)
        {
            bd.BuildPartA();
            bd.BuildPartB();
        }
    }
}
