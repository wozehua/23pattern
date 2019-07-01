﻿namespace CompositePattern_组合模式_.TreeLeaf
{
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
