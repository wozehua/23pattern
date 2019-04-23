using System;

namespace PrototypePattern_原型模式_.继承ICloneable
{
    public class ResumeDeepCopy:ICloneable
    {
        private string _name;
        private string _sex;
        private int _age;
        private readonly WorkExperienceDeepCopy _workExperienceDeepCopy;

        public ResumeDeepCopy(string name)
        {
            _name = name;
            _workExperienceDeepCopy = new WorkExperienceDeepCopy();
        }

        private ResumeDeepCopy(WorkExperienceDeepCopy workExperienceDeepCopy)
        {
            _workExperienceDeepCopy = (WorkExperienceDeepCopy)workExperienceDeepCopy.Clone();
        }
        public void SetPersonalInfo(string sex, int age)
        {
            _sex = sex;
            _age = age;
        }

        public void SetWorkExperience(DateTime workDate, string company)
        {
            _workExperienceDeepCopy.WorkDate = workDate;
            _workExperienceDeepCopy.Company = company;
        }

        public void Display()
        {
            Console.WriteLine($"姓名:{_name},性别：{_sex},年龄：{_age}");
            Console.WriteLine($"工作经历:{_workExperienceDeepCopy.WorkDate}  {_workExperienceDeepCopy.Company}");
            Console.WriteLine();
        }
        public object Clone()
        {
            ResumeDeepCopy resumeDeepCopy = new ResumeDeepCopy(_workExperienceDeepCopy);
            resumeDeepCopy._name = _name;
            resumeDeepCopy._sex = _sex;
            resumeDeepCopy._age = _age;
            return resumeDeepCopy;
        }
    }
}
