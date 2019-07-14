using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorPattern_中介者模式_.Example
{
    abstract class UnitNations
    {
        public abstract void Declare(string message, Country country);
    }
}
