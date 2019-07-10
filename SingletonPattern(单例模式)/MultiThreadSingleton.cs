namespace SingletonPattern_单例模式_
{
    /// <summary>
    /// 多线程单例
    /// </summary>
    class MultiThreadSingleton
    {
        /// <summary>
        /// lock是确保当一个线程位于代码的临界区时，另一个线程不进入临界区。
        /// 如果其他线程试图进入锁定的代码，则它将一致等待（即被阻止），直到该对象被释放。
        /// </summary>
        private static MultiThreadSingleton _multiThreadSingleton;
        private static readonly object SyncRoot = new object();

        private MultiThreadSingleton()
        {
            
        }

        public static MultiThreadSingleton GetMultiThreadSingleton()
        {
            //双重锁定 double-check-locking
            if (_multiThreadSingleton == null)
            {
                lock (SyncRoot)
                {
                    if (_multiThreadSingleton == null) _multiThreadSingleton = new MultiThreadSingleton();
                }
            }
            

            return _multiThreadSingleton;
        }
        
    }
}
