using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern_建造者模式_
{
    class Program
    {
        //建造者模式又叫生成器模式。
        static void Main(string[] args)
        {
            //建造者模式
            //将一个复杂对象的构建与它的表示分离,使得同样的构建过程可以创建不同的表示。
            //建造者模式可以将一个产品的内部表象与产品的生成过程分开。从而使一个建造
            //过程生成具有不同的内部表象的产品对象。
            ConcreteBuilder1 concreteBuilder1 = new ConcreteBuilder1();
            ConcreteBuilder2 concreteBuilder2 = new ConcreteBuilder2();
            Director director = new Director();
            director.Construct(concreteBuilder2);
            Product product = concreteBuilder2.GetResult();
            product.Show();

            director.Construct(concreteBuilder1);
            Product product2 = concreteBuilder1.GetResult();
            product2.Show();
            Console.Read();

        }
    }
}
