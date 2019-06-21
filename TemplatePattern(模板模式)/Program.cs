using System;

namespace TemplatePattern_模板模式_
{
    /// <summary>
    /// 模板方法模式：定义一个操作中的算法的骨架，而将一些步骤延迟到子类中，模板方法使得子类
    /// 可以不改变一个算法的结构极客重定义该算法的某些步骤。
    /// 特点：模板方法模式是通过把不变行为搬移到超类，去除子类中重复代码来体现它的优势。
    /// 模板方法模式体现乐乐一个很好代码复用平台。
    /// 说明：我们会遇到一系列不走构成过程需要执行。这个过程从高层次上看是相同的，但有些步骤的实现可能不同。
    /// 这时候，我们通常就应该要考虑用模板方法模式。
    /// 总结：当不变和可变的行为在方法的子类中实现中混合在一起的时候，不变的行为就会在子类中重复出现。
    /// 我们通过模板方法模式把这些行为搬移到单一的地方。这样就帮助子类摆脱了重复不变行为的纠缠。
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            TestParper a = new TestPaperA();
            a.AllQuestion();

            a = new TestParperB();
            a.AllQuestion();
            Console.Read();
        }
    }
}
