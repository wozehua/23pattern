namespace SingletonPattern_单例模式_
{
    /// <summary>
    /// 静态初始化
    /// c#与公共语言运行库也提供了一种‘静态初始化’方法，这种方法不需要开发人员显示地编写线程安全代码
    /// 即可解决多线程环境下他是不安全的问题。
    /// 单例模式 视图解决的两个基本问题：全局访问和实例化控制。
    /// 标记为readonly 这意味着只能在静态初始化期间或在类构造函数中分配变量。
    /// 这种静态初始化的方式是在自己被加载时就将自己实例化，所以被形象地称为饿汉式单例模式。
    /// 原先的单例模式式要在第一次被引用时，才会将自己实例化，所以就被称为懒汉式单例类。
    /// </summary>
    public sealed class StaticSingleton
    {
        /// <summary>
        /// sealed 阻止发生派生，而派生可能会增加实例。
        /// 饿汉式，即静态初始化方式，他是类一加载就实例化对象，所以要提前占用系统资源。
        /// 懒汉式，又会面临着多线程访问的安全性问题。需要做双重锁定这样的处理才可以保证安全。
        /// </summary>
        private static readonly StaticSingleton staticSingleton = new StaticSingleton();

        private StaticSingleton()
        {
            
        }

        public static StaticSingleton GetSingleton()
        {
            return staticSingleton;
        }
    }
}
