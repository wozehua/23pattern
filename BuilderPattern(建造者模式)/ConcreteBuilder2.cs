namespace BuilderPattern_建造者模式_
{
    /// <summary>
    /// 测试分支
    /// </summary>
    class ConcreteBuilder2:Builder
    {
        private Product product = new Product();
        public override void BuildPartA()
        {
            product.Add("部件A");
        }

        public override void BuildPartB()
        {
            product.Add("部件B");
        }

        public override Product GetResult()
        {
            return product;
        }
    }
}
