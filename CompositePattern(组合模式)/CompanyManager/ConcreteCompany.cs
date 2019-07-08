using System;
using System.Collections.Generic;

namespace CompositePattern_组合模式_.CompanyManager
{
    class ConcreteCompany:Company
    {
        private readonly List<Company> _companies = new List<Company>();
        public ConcreteCompany(string name) : base(name)
        {
        }

        public override void Add(Company company)
        {
            _companies.Add(company);
        }

        public override void Remove(Company company)
        {
            _companies.Remove(company);
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new string('-',depth) + Name);
            foreach (var company in _companies)
            {
                company.Display(depth + 2);
            }
        }

        public override void LineOfDuty()
        {
            foreach (var company in _companies)
            {
                company.LineOfDuty();
            }
        }
    }
}
