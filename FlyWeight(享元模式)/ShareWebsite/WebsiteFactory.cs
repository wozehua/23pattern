using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace FlyWeight_享元模式_.ShareWebsite
{
    class WebsiteFactory
    {
        private Hashtable hashtable = new Hashtable();

        public Website GetWebsite(string key)
        {
            if (!hashtable.ContainsKey(key))
                hashtable.Add(key, new ConcreteWebsite(key));
            return (Website) hashtable[key];
        }

        public int GetWebSiteCount()
        {
            return hashtable.Count;
        }
    }
}
