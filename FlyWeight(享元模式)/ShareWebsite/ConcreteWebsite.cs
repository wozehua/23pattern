using System;
using System.Collections.Generic;
using System.Text;

namespace FlyWeight_享元模式_.ShareWebsite
{
    class ConcreteWebsite:Website
    {
        private string _name;
        public ConcreteWebsite(string name)
        {
            _name = name;
        }
        public override void Use()
        {
            Console.WriteLine($"网站分类{_name}");
        }
    }
}
