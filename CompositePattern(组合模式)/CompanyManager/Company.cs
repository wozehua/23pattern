namespace CompositePattern_组合模式_.CompanyManager
{
    public abstract class Company
    {
        protected string Name;

        protected Company(string name)
        {
            Name = name;
        }

        public abstract void Add(Company company);
        public abstract void Remove(Company company);

        public abstract void Display(int depth);

        public abstract void LineOfDuty();


    }
}
