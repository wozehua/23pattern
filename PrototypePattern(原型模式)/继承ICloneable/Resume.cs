using System;

namespace PrototypePattern_原型模式_.继承ICloneable
{
    public class Resume:ICloneable
    {
        private readonly string _name;
        private string _sex;
        private int _age;
        private readonly WorkExperience _workExperience;

        public Resume(string name)
        {
            _workExperience = new WorkExperience();
            _name = name;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sex"></param>
        /// <param name="age"></param>
        public void SetPersonalInfo(string sex, int age)
        {
            _sex = sex;
            _age = age;
        }

        public void SetWorkExperience(DateTime workDate, string company)
        {
            _workExperience.WorkDate = workDate;
            _workExperience.Company = company;
        }

        public void Display()
        {
            Console.WriteLine($"姓名:{_name},性别：{_sex},年龄：{_age}");
            Console.WriteLine($"工作经历:{_workExperience.WorkDate}  {_workExperience.Company}");
            Console.WriteLine();
        }
        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
