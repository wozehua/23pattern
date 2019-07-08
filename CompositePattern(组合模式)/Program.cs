using System;
using CompositePattern_组合模式_.CompanyManager;
using CompositePattern_组合模式_.TreeLeaf;

namespace CompositePattern_组合模式_
{
    /// <summary>
    /// 组合模式：将对象组合成树型结构以表示‘部分-整体’的层次结构。
    /// 组合模式使得用户对单个对象和组合对象的使用具有一致性。
    /// 何时使用组合模式：需求中是体现部分与整体层次的结构时，以及你希望用户可以忽略组合对象与单个
    /// 对象的不同，统一地使用组合结构中的所有对象时，就应该考虑用组合模式了。
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            #region 树列子
            Composite root = new Composite("root");
            root.Add(new Leaf("Leaf A"));
            root.Add(new Leaf("Leaf B"));

            Composite comp = new Composite("Composite X");
            comp.Add(new Leaf("Leaf XA"));
            comp.Add(new Leaf("Leaf XB"));
            root.Add(comp);

            Composite comp2 = new Composite("CompositeXY");
            comp2.Add(new Leaf("Leaf XYA"));
            comp2.Add(new Leaf("Leaf XYB"));
            comp.Add(comp2);
            root.Add(new Leaf("Leaf C"));
            Leaf leaf = new Leaf("Leaf D");
            root.Add(leaf);
            root.Remove(leaf);
            root.Display(1);
            #endregion

            ConcreteCompany concreteCompany = new ConcreteCompany("北京总公司");
            concreteCompany.Add(new HRDepartment("总公司人力资源部"));
            concreteCompany.Add(new FinanceDepartment("总公司财务部"));

            ConcreteCompany concreteCompany2 = new ConcreteCompany("上海华东分公司");
            concreteCompany2.Add(new HRDepartment("华东分公司人力资源部"));
            concreteCompany2.Add(new HRDepartment("华东分公司财务部"));
            concreteCompany.Add(concreteCompany2);
            ConcreteCompany concreteCompany3 = new ConcreteCompany("南京分公司");
            concreteCompany3.Add(new HRDepartment("南京分公司人力资源部"));
            concreteCompany3.Add(new HRDepartment("南京分公司财务部"));
            concreteCompany2.Add(concreteCompany3);
            ConcreteCompany concreteCompany4 = new ConcreteCompany("杭州分公司");
            concreteCompany4.Add(new HRDepartment("杭州分公司人力资源部"));
            concreteCompany4.Add(new HRDepartment("杭州分公司财务部"));
            concreteCompany.Add(concreteCompany4);
            Console.WriteLine("\n 结构图");
            concreteCompany.Display(1);
            Console.WriteLine("\n 职责");
            concreteCompany.LineOfDuty();
            Console.Read();

        }
    }
}
