using System;
using ObserverPattern_观察这模式_.OriginObserverPattern;
using DeCoupling=ObserverPattern_观察这模式_.DeCouplingObserverPattern;
using EventHandler=ObserverPattern_观察这模式_.EventHandlerObserverPattern;

namespace ObserverPattern_观察者模式_
{
    /// <summary>
    /// 观察这模式又叫做发布-订阅（Publish/Subscribe）模式
    /// 定义了一种一对多的依赖关系，让多个观察这对象同时监听某一个主题对象，这个主题对象在状态发生变化时，
    /// 会通知所有观察这对象，使他们能够自动更新自己。
    /// </summary>
    class Program
    {
        /// <summary>
        /// 如果类与类之间耦合度高的话（如类A和类B相互依赖之类的 这种的话就要考虑抽象出抽象类或接口）
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            #region 原始观察者模式 没有解耦的
            //观察者
            //Secretary secretary = new Secretary();
            //StockObserver stockObserver = new StockObserver("看股票的人A", secretary);
            //StockObserver stockObserverB = new StockObserver("看股票的人B", secretary);
            //secretary.Attach(stockObserver);
            //secretary.Attach(stockObserverB);
            //secretary.SecretaryAction = "老板来了";
            //secretary.Notify(); 
            #endregion

            #region 解耦后的观察者模式
            //这个就是把Secretary原先耦合的类StockObserver 给用抽象类Observer代替 解开Secretary和StockObserver两者的耦合
            //这边还有一个耦合就是StockObserver和NBAObserver中与Secretary的耦合//这个抽象出接口ISubject
            //所谓的耦合就是 对象类之间的相互调用，这种可以用抽象类和接口来替代掉原先具体的类
            //var secretary =new DeCoupling.Secretary();
            //var stockObserver= new DeCoupling.StockObserver("看股票的人", secretary);

            //var nbaObserver = new DeCoupling.NBAObserver("看NBA的人", secretary);
            //secretary.Attach(stockObserver);
            //secretary.Attach(nbaObserver);
            ////secretary.DeAttach(stockObserver);
            //secretary.SubjectState = "老板来了";
            //secretary.Notify();

            #endregion

            #region 事件委托的观察这模式
            //委托就是一种引用方法的类型。一旦为委托分配方法，委托将与该方法具有完全相同的行为。
            //委托方法的使用可以像其他任何方法一样，具有参数和返回值。委托可以看作是对函数的抽象，是函数的‘类’委托的实例
            //将代表一个具体的函数。
            //委托可以搭载多个方法,所有方法被依次唤起。 更总要的是，它可以使得委托对所搭载的方法并不需要属于同一个类。
            //d但委托也是有前提的，那就是委托对象所搭载的所有方法必须具有相同的原形和形式，也就是拥有相同的参数列表和返回值类型。
            //这边主要修改了ISubject接口中的添加和移除观察者 
            //具体通知者类增加委托时间，并在Notify方法中调用这个委托事件。
            var secretary = new EventHandler.Secretary();
            var stockObserver = new EventHandler.StockObserver("afasd", secretary);
            var nbaObserver = new EventHandler.NBAObserver("阿斯蒂芬", secretary);
            secretary.Update += stockObserver.CloseStockMarket;
            secretary.Update+= nbaObserver.CloseNbaDirectSeeding;
            secretary.SubjectState = "老板回来了";
            secretary.Notify();
            #endregion
            Console.Read();
        }
    }
}
