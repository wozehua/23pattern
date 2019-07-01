using System;

namespace CompositePattern_组合模式_.TreeLeaf
{
    //透明模式
    class Leaf:Component
    {
        public Leaf(string name) : base(name)
        {
        }

        public override void Add(Component component)
        {
            Console.WriteLine("Cannot add to a leaf");
        }

        public override void Remove(Component component)
        {
            Console.WriteLine("Cannot Remove from a leaf");
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new string('-',depth)+Name);
        }
    }
}
