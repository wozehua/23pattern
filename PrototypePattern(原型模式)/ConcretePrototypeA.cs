using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern_原型模式_
{
    class ConcretePrototypeA:Prototype
    {
        public ConcretePrototypeA(string id) : base(id)
        {
        }

        public override Prototype Clone()
        {
            //浅复制.创建当前对象的浅表副本
            //方法是创建一个新对象，然后将当前对象的非静态字段复制到该新对象
            //如果字段是值类型，对该字段执行逐位复制
            //如果是引用类型，则复制引用但不复制引用的对象，因此原始对象及其副本引用同一对象
            //浅复制的引用类型 复制完后的对象引用地址指向和原来复制的对象同样的引用地址 所以如果
            //改变复制完后的对象的值,原来被复制的对象的值也会跟着改变
            //如果不想被影响可以使用 深复制
            return (Prototype)MemberwiseClone();
        }
    }
}
