using System;

namespace CompositePattern_组合模式_.CompanyManager
{
    /// <summary>
    /// 树叶节点
    /// </summary>
    public class HRDepartment:Company
    {
        public HRDepartment(string name) : base(name)
        {
        }

        public override void Add(Company company)
        {
            
        }

        public override void Remove(Company company)
        {
            
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new string('-',depth)+Name);
        }

        public override void LineOfDuty()
        {
            Console.WriteLine($"{Name}员工招聘培训管理");
        }
    }
}
