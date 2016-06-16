using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Composite
{
    //抽象工厂类
    public abstract class Company
    {

        protected string name;
        public Company(string name) 
        {
            this.name = name;
        }

        public abstract void Add(Company c);
        public abstract void Remove(Company c);
        public abstract void Show(int dept);

        public abstract void LineOfDuty();
    }

    //具体公司
    public class ConcreteCompany:Company 
    {
        private List<Company> list = new List<Company>();
        public ConcreteCompany(string name) : base(name) 
        {
        }

        public override void Add(Company c)
        {
            list.Add(c);
        }
        public override void Remove(Company c)
        {
            list.Remove(c);
        }

        public override void Show(int dept)
        {
            Console.WriteLine(new String('-',dept)+name);
            foreach (var item in list)
            {
                item.Show(dept+2);
            }
        }

        public override void LineOfDuty()
        {
            foreach (var item in list)
            {
                item.LineOfDuty();
            }
        }
    }

    //财务部
    public class FinanceDepartment : Company 
    {
        public FinanceDepartment(string name)
            : base(name)
        { }

        public override void Add(Company c)
        {
        
        }
        public override void Remove(Company c)
        {
           
        }
        public override void Show(int dept)
        {
            Console.WriteLine(new String('-', dept)+name);
        }
        public override void LineOfDuty()
        {
            Console.WriteLine("我是{0}的，我负责发工资",name);
        }
      
    }
    //人事部门
    public class HRDepartment : Company
    {
        public HRDepartment(string name)
            : base(name)
        { }

        public override void Add(Company c)
        {
        
        }
        public override void Remove(Company c)
        {
           
        }
        public override void Show(int dept)
        {
            Console.WriteLine(new String('-', dept)+name);
        }
        public override void LineOfDuty()
        {
            Console.WriteLine("我是{0}的，我负责招聘新员工",name);
        }
    }

}
