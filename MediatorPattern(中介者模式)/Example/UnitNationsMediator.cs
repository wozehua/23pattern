using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorPattern_中介者模式_.Example
{
    class UnitNationsMediator:UnitNations
    {
        private USA _uSa;
        public USA USA
        {
            set => _uSa = value;
        }
        private Iraq _iraq;
        public Iraq Iraq
        {
            set => _iraq = value;
        }
        public override void Declare(string message, Country country)
        {
            if (country == _uSa)
            {
                _uSa.GetMessage(message);
            }
            else
            {
                _iraq.GetMessage(message);
            }

           
        }
    }
}
