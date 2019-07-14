using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorPattern_中介者模式_.Example
{
    abstract class Country
    {
        protected UnitNations unitNations;

        public Country(UnitNations unitNations)
        {
            this.unitNations = unitNations;
        }
    }
}
