using System;
using System.Collections.Generic;
using System.Text;

namespace TemplatePattern_模板模式_
{
    public class TestParperB:TestParper
    {
        protected override string Answer1()
        {
            return "我是试卷B的答案1";
        }

        protected override string Answer2()
        {
            return "我是试卷B的答案2";
        }

        protected override string Answer3()
        {
            return "我是试卷B的答案3";
        }
    }
}
