using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace FlyWeight_享元模式_
{
    class FlyWeightFactory
    {
        private Hashtable _flyweights = new Hashtable();

        public FlyWeightFactory()
        {
            _flyweights.Add("x", new ConcreteFlyWeight());
            _flyweights.Add("y", new ConcreteFlyWeight());
            _flyweights.Add("z", new ConcreteFlyWeight());
        }

        public FlyWeight GetFlyWeight(string key)
        {
            return ((FlyWeight) _flyweights[key]);
        }
    }
}
