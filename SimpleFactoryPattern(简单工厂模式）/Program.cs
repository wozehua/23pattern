using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryPattern_简单工厂模式_
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 创建型模式和简单工厂介绍
            //创建型模式（Create Pattern)对类的实例化过程进行了抽象
            //能够将软件模块中的对象的创建和对象的使用分离
            //为了使软件的结构更加清晰,外界对于这些对象只需要知道共同的接口
            //而不需要知道他们具体的实现,使整个系统满足单一职责。
            // 创建型模式隐藏了类的实例的创建细节，通过隐藏对象如何被创建和组合在一起达到使整个系统独立的目的。 

            //简单工厂模式定义：
            //Simple Factory Pattern(简单工厂模式）：又称为静态工厂方法（static Factory Method) 他属于创建型模式。
            //简单工厂模式中，可以根据参数的不同返回不同的类的实例。
            //简单工厂模式专门定义一个类来负责创建其他类的实例。被创建的实例通常都具有共同的父类。
            //简单工厂模式最大的问题在于工厂类的职责相对过重，增加新的产品需要修改工厂类的判断逻辑，这一点与开闭原则是相违背的。
            //简单工厂模式的要点在于：当你需要什么，只需要传入一个正确的参数，就可以获取你所需要的对象，而无须知道其创建细节。
            // 将对象的创建和对象本身业务处理分离可以降低系统的耦合度

            //简单工厂的优缺点：
            //简单工厂模式的优点
            //•工厂类含有必要的判断逻辑，可以决定在什么时候创建哪一个产品类的实例，客户端可以免除直接创建产品对象的责任，而仅仅“消费”产品；简单工厂模式通过这种做法实现了对责任的分割，它提供了专门的工厂类用于创建对象。
            //•客户端无须知道所创建的具体产品类的类名，只需要知道具体产品类所对应的参数即可，对于一些复杂的类名，通过简单工厂模式可以减少使用者的记忆量。
            //•通过引入配置文件，可以在不修改任何客户端代码的情况下更换和增加新的具体产品类，在一定程度上提高了系统的灵活性。
            //简单工厂模式的缺点
            //•由于工厂类集中了所有产品创建逻辑，一旦不能正常工作，整个系统都要受到影响。
            //•使用简单工厂模式将会增加系统中类的个数，在一定程序上增加了系统的复杂度和理解难度。
            //•系统扩展困难，一旦添加新产品就不得不修改工厂逻辑，在产品类型较多时，有可能造成工厂逻辑过于复杂，不利于系统的扩展和维护。
            //•简单工厂模式由于使用了静态工厂方法，造成工厂角色无法形成基于继承的等级结构。 
            #endregion
            //简单工厂的优点在于工厂类中包含了必要的逻辑判断,根据客户端的选择条件动态实例化相关的类
            //对于客户端来说,去除了与具体产品的依赖
            //但是当我们要扩展一个类的时候就要去改动工厂原来的类，这样就违背了开放-封闭原则 对扩展开放，对修改封闭
            //所以就有了工厂模式
            Operation oper;
            oper = OperationFactory.CreateOperation("+");
            oper.NumberA = 78;
            oper.NumberB = 56;
            double result = oper.GetResult();
            Console.WriteLine($"加法算法{result}");

            oper = OperationFactory.CreateOperation("-");
            oper.NumberA = 10;
            oper.NumberB = 20;
            result = oper.GetResult();
            Console.WriteLine($"减法算法{result}");

            oper = OperationFactory.CreateOperation("/");
            oper.NumberA = 20;
            oper.NumberB = 30;
            result = oper.GetResult();
            Console.WriteLine($"除法算法{result}");

            oper = OperationFactory.CreateOperation("*");
            oper.NumberA = 4;
            oper.NumberB = 6;
            result = oper.GetResult();
            Console.WriteLine($"乘法算法{result}");
            Console.ReadKey();
        }
    }
}
