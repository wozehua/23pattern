namespace BuilderPattern_建造者模式_
{
    class Director
    {
        public void Construct(Builder bd)
        {
            bd.BuildPartA();
            bd.BuildPartB();
        }
    }
}
