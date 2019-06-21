using System;

namespace TemplatePattern_模板模式_
{
    public class TestParper
    {
        public void TestQuestion1()
        {
            Console.WriteLine("测试题目1");
            Console.WriteLine("答案:"+Answer1());
        }

        protected virtual string Answer1()
        {
            return "";
        }
        public void TestQuestion2()
        {
            Console.WriteLine("测试题目2");
            Console.WriteLine("答案:" + Answer2());
        }

        protected virtual string Answer2()
        {
            return "";
        }
        public void TestQuestion3()
        {
            Console.WriteLine("测试题目3");
            Console.WriteLine("答案:" + Answer3());
        }

        protected virtual string Answer3()
        {
            return "";
        }

        public void AllQuestion()
        {
            TestQuestion1();
            TestQuestion2();
            TestQuestion3();
        }
    }
}
