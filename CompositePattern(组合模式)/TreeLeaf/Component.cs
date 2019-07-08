namespace CompositePattern_组合模式_.TreeLeaf
{
    /// <summary>
    /// 这个是组合模式的透明模式
    /// 还有一个就是组合模式的安全模式：就是将Add和Remove移除 将他放到Composite 中实现。
    /// 因为安全模式的树叶是不用在章分支的。就是不用实现add和Remove.
    /// 不过由于不够透明，所以树叶和树枝类将不具有相同的接口。
    /// </summary>
    abstract class Component
    {
        protected string Name;

        protected Component(string name)
        {
            Name = name;
        }

        public abstract void Add(Component component);


        public abstract void Remove(Component component);

        public abstract void Display(int depth);
    }
}
