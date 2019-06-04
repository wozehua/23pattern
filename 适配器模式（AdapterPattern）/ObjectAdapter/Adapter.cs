namespace 适配器模式_AdapterPattern_.ObjectAdapter
{
    /// <summary>
    /// 通过在内部包装一个Adaptee对象，把源接口转换成目标接口
    /// </summary>
    class Adapter:Target
    {
        /// <summary>
        /// 建立一个私有的Adaptee对象
        /// </summary>
        private readonly Adaptee _adaptee = new Adaptee();
        public override void Request()
        {
            //这样就可以把表面上调用Request()方法变成实际调用的SpecificRequest();
            _adaptee.SpecificRequest();
        }
    }
}
