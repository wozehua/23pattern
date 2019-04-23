using System;
using PrototypePattern_原型模式_.继承ICloneable;

namespace PrototypePattern_原型模式_
{
    class Program
    {
        /// <summary>
        /// 原型模式，用原型实例指定创建对象的种类，并通过拷贝这些原型创建新的对象
        /// 原型模式其实就是从一个对象在创建另外一个可定制的对象，而且不需知道任何创建的细节
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("========Start:没有继承C# IConeable接口实现的浅复制原型模式=========");
            ConcretePrototypeA cpa = new ConcretePrototypeA("I");
            ConcretePrototypeA cpaShallCopy = (ConcretePrototypeA)cpa.Clone();
            Console.WriteLine("Cloned:{0}",cpaShallCopy.Id);
            Console.WriteLine("========End:没有继承C# IConeable接口实现的浅复制原型模式===========");
            #region IConeable说明
            Console.WriteLine("========Start:继承C# IConeable接口实现的浅复制原型模式=============");
            //.Net 在System 命名空间中提供了IConeable 接口，我们实现这个接口就可以完成原型模式了
            Resume resume = new Resume("测试1");
            resume.SetPersonalInfo("男", 20);
            resume.SetWorkExperience(DateTime.Now, "测试公司");

            Resume resumeShallowCopy = (Resume)resume.Clone();
            resumeShallowCopy.SetWorkExperience(DateTime.Now.AddYears(-1), "AA公司");

            Resume resumeShallowCopyB = (Resume) resume.Clone();
            resumeShallowCopyB.SetPersonalInfo("女", 18);
            resumeShallowCopyB.SetWorkExperience(DateTime.Now.AddYears(-2), "ZZ公司");

            resume.Display();
            resumeShallowCopy.Display();
            resumeShallowCopyB.Display();
            Console.WriteLine("==========End继承C# IConeable接口实现的浅复制原型模式===================");
            #region 深复制
            //实现深复制的方式 反射（注意相互引用问题） 序列化和反序列化 表达式树
            Console.WriteLine("========Start:继承C# IConeable接口实现的深复制原型模式=============");
            //.Net 在System 命名空间中提供了IConeable 接口，我们实现这个接口就可以完成原型模式了
            ResumeDeepCopy resumeDeepCopy = new ResumeDeepCopy("测试1");
            resumeDeepCopy.SetPersonalInfo("男", 20);
            resumeDeepCopy.SetWorkExperience(DateTime.Now, "测试公司");

            ResumeDeepCopy resumeDeepCopyA = (ResumeDeepCopy)resumeDeepCopy.Clone();
            resumeDeepCopyA.SetWorkExperience(DateTime.Now.AddYears(-1), "AA公司");

            ResumeDeepCopy resumeDeepCopyB = (ResumeDeepCopy)resumeDeepCopy.Clone();

            resumeDeepCopyB.SetPersonalInfo("女", 18);
            resumeDeepCopyB.SetWorkExperience(DateTime.Now.AddYears(-2), "ZZ公司");

            resumeDeepCopy.Display();
            resumeDeepCopyA.Display();
            resumeDeepCopyB.Display();
            Console.WriteLine("==========End继承C# IConeable接口实现的深复制原型模式==================="); 
            #endregion

            #region 浅复制模式说明
            //执行浅复制原型模式 我们可以发现两个问题
            //1：引用类型（例子中的SetWorkExperience）赋值后浅复制的引用类型也发生改变了
            #region 问题2解答
            //因为浅复制的时候 复制的是引用类型的引用（引用地址），不复制引用的对象。
            //所以上面三个工作经历指向的都是同一个引用地址,当我们赋值之后其他指向这个引用地址的对象值也跟着改变

            #endregion
            //2：string 字符串也是引用类型为什么他没变呢?这不就和1冲突了吗?
            #region 问题2解答 
            // 字符串内部实现 public static readonly string Empty;
            //字符串的不可变性(恒定性):当你给一个字符串重新赋值之后,老值并没有被销毁,而是重新开辟了一块空间存储新值IL(中可以查看)
            //所以我们使用字符串扩展方法时，其实都是一个新的对象(Trim)
            //
            //字符串的驻留机制
            //CLR中维护着一个驻留池(Intern Pool)的散列表（HashTable）,这个表记录了所有在代码中使用字面量声明的字符串实例的引用
            //使用字面量声明的字符串都会被记录到散驻留池（散列表 键为字符串 值为字符串存储地址）
            //String.Intern(参数)

            #region String.Intern 说明
            //Intern方法接受一个字符串作为参数，它会在驻留池中检查是否存在参数所表示的字符串。
            //如果存在，则返回那个驻留池中的字符串的引用；否则向驻留池中加入一个新的表示相同值的字符串，
            //并返回这个字符串的引用。不过要注意的是，就算Intern方法在驻留池中找到了相同值的字符串，
            //也不能让您省却一次字符串内存分配的操作，因为作为参数的字符串已经被分配了一次内存了。
            //而使用Intern方法的好处在于，如果Intern方法在驻留池中找到了相同值的字符串，
            //此时虽然在内存中存在两份该字符串的副本（一份是参数，一份是驻留池中的），
            //参数所引用的那个副本会被垃圾回收掉，这样对于该字符串内存中就不存在冗余了。
            #endregion
            //正是字符串的恒定性，才造就了字符串的驻留机制，
            //也为字符串的线程同步工作大开方便之门（同一个字符串对象可以在不同的应用程序域中被访问，
            //所以驻留的字符串是进程级的，垃圾回收不能释放这些字符串对象，只有进程结束这些对象才被释放）。
            //字面量是源代码中书写的数字或字符串，用来表示一个明确类型的明确、固定的值。
            //字符串字面量（string literal）是指双引号引住的一系列字符,字符串字面量使用双引号标记

            #region 驻留机制例子

            //　String s = "Hello";
            //Console.WriteLine(Object.ReferenceEquals("Hello", s));
            //这段代码显示的是"True"还是"False"呢？可能大家认为是返回"False"，
            //毕竟，我们有两个"Hello"字符串，且ReferenceEuqals只有在两个引用都指向同一对象时才返回true。
            //然而，这段代码显示的是"True"。
            //当CLR初始化时，它会创建一个内部的散列表，其中的键为字符串，
            //值为指向托管堆中字符串对象的引用。刚开始，该表为空。
            //当JIT编译器编译方 法要创建字符串时，它会在散列表中查找每一个文本常量字串。
            //以上面的代码为例，编译器首先会查找第一个"Hello"字符串，
            //且因为没有找到，便会在托管 堆中构造一个新的String对象（指向该字符串），
            //然后将"Hello"字串和指向该对象的引用添加到散列表中。接着，
            //JIT编译器在散列表中查找第二 个"Hello"字符串，这次因为会找到该字符串，所以不执行任何操作。

            #endregion
            #endregion
            #endregion
            #endregion

            #region 快捷键

            //Ctrl+D 复制当前列 也可以复制当前选中的列

            #endregion

            Console.Read();
        }
    }
}
