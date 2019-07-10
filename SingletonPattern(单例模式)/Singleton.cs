namespace SingletonPattern_单例模式_
{
    class Singleton
    {
        private static Singleton _singleton;
        /// <summary>
        /// 构造方法让其private,这就堵死了外接利用new创建此实例的可能
        /// </summary>
        private Singleton()
        {
        }

        public static Singleton GetSingleton()
        {
            return _singleton ?? (_singleton = new Singleton());
        }
    }
}
