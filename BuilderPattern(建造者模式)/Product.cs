using System;
using System.Collections.Generic;

namespace BuilderPattern_建造者模式_
{
    class Product
    {
        private List<string> parts = new List<string>();

        public void Add(string part)
        {
            parts.Add(part);
        }

        public void Show()
        {
            Console.WriteLine("\n 产品 创建 ----");
            foreach (var item in parts)
            {
                Console.WriteLine(item);
            }
        }
        
        
    }
}
