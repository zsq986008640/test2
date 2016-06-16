using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrototypePattern
{

    public class WorkExperience :ICloneable
    {
        public string WorkDate { get; set;}

        public string Company { get; set; }

        public Object Clone() 
        {
            return this.MemberwiseClone();
        }

    }

    public class Resume:ICloneable
    {
        private string name;
        private string sex;
        private string age;
        //private string timeArea;
        //private string company;
        private  WorkExperience work;
        public Resume(string name) 
        {
            this.name = name;
            work = new WorkExperience();
        }

        private Resume(WorkExperience work) 
        {
            this.work = (WorkExperience)work.Clone();
        }
        //设置个人信息
        public void SetPersonInfo(string sex,string age) 
        {
            this.sex = sex;
            this.age = age;
        }
        //设置工作经历
        public void SetWorkExperience(string tiemArea,string company) 
        {
            work.WorkDate = tiemArea;
            work.Company = company;
        }

        public void Display() 
        {
            Console.WriteLine("{0} {1} {2}",name,sex,age);
            Console.WriteLine("工作经历：{0}  {1}", work.WorkDate, work.Company);
        }

        public Object Clone() 
        {
            Resume resume = new Resume(this.work);
            resume.name = this.name;
            resume.age = this.age;
            resume.sex = this.sex;
            return resume;
        }
    }
}
