using System;
using CompositePattern_组合模式_.TreeLeaf;

namespace CompositePattern_组合模式_
{
    /// <summary>
    /// 组合模式：将对象组合成树型结构以表示‘部分-整体’的层次结构。
    /// 组合模式使得用户对单个对象和组合对象的使用具有一致性。
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
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
            Console.Read();

        }
    }
}
