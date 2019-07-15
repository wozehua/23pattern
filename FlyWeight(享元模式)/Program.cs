using System;
using FlyWeight_享元模式_.ShareWebsite;

namespace FlyWeight_享元模式_
{
    /// <summary>
    /// 享元模式应用：
    /// 如果一个应用程序使用了大量的对象，而大量的这些对象造成了很大的存储开销时就应该考虑使用
    /// 还有就是对象的大多数状态可以外部状态，如果删除对象的外部状态，那么可以用相对较少的共享对象取代很多组对象，
    /// 此时可以考虑使用享元模式。
    /// </summary>
    class Program
    {
        /// <summary>
        /// 享元模式：运用共享技术有效地支持大量细粒度的对象。\
        /// 在享元对象内部并且不会随环境改变而改变的共享部分，可以称为享元对象的内部状态。
        /// 随环境改变而改变的、不可以共享的状态就是外部状态。
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            #region 例子
            //int extrinsicstate = 22;
            //FlyWeightFactory flyWeightFactory = new FlyWeightFactory();
            //FlyWeight fx = flyWeightFactory.GetFlyWeight("x");
            //fx.Operation(--extrinsicstate);

            //FlyWeight fy = flyWeightFactory.GetFlyWeight("y");
            //fy.Operation(--extrinsicstate);
            //FlyWeight fz = flyWeightFactory.GetFlyWeight("z");
            //fz.Operation(--extrinsicstate);
            //FlyWeight fu = new UnsharedConcreteFlyWeight();
            //fu.Operation(--extrinsicstate); 
            #endregion

            #region MyRegion

            WebsiteFactory f = new WebsiteFactory();
            Website fx = f.GetWebsite("产品展示");
            fx.Use();
            Website fy = f.GetWebsite("产品展示");
            fy.Use();

            var fl = f.GetWebsite("博客");
            fl.Use();
            Console.WriteLine($"网站分类总数为{f.GetWebSiteCount()}");
            #endregion
            Console.Read();

        }
    }
}
