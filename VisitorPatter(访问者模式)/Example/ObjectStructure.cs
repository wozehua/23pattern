using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorPatter_访问者模式_.Example
{
    class ObjectStructure
    {
        private IList<Person> people = new List<Person>();

        public void Attach(Person person)
        {
            people.Add(person);
        }

        public void Detach(Person person)
        {
            people.Remove(person);
        }

        public void Display(Action action)
        {
            foreach (var e in people)
            {
                e.Accept(action);
            }
        }
    }
}
