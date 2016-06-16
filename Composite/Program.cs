using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteCompany c = new ConcreteCompany("总公司");
            c.Add(new HRDepartment("北京总公司人事部"));
            c.Add(new FinanceDepartment("北京总公司财务部"));

            ConcreteCompany c1 = new ConcreteCompany("上海分公司");
            c1.Add(new HRDepartment("上海分公司人事部"));
            c1.Add(new FinanceDepartment("上海分公司财务部"));
            c.Add(c1);
            ConcreteCompany c2 = new ConcreteCompany("杭州分公司");
            c2.Add(new HRDepartment("杭州分公司人事部"));
            c2.Add(new FinanceDepartment("杭州分公司财务部"));
            c.Add(c2);

            c.Show(1);
            c.LineOfDuty();
            Console.ReadLine();
        }
    }
}

//题目：
//有三个桶，两个大桶分别可装8斤的水，一个小桶可装3斤的水。现在有2个8斤的桶全部装满了水，3斤的小桶空着。

//要求：
//如何把这16斤水平均分给4个人，每人4斤水。注意：不能使用其他任何工具，4人自备容器，分出去的水不可再要回来。


//Composite root = new Composite("root");

//root.Add(new Leaf("Leaf A"));
//root.Add(new Leaf("Leaf B"));

//Composite comp = new Composite("Composite X");
//comp.Add(new Leaf("Leaf XA"));
//comp.Add(new Leaf("Leaf XB"));
//root.Add(comp);

//Composite comp2 = new Composite("Composite XY");
//comp2.Add(new Leaf("Leaf XYA"));
//comp2.Add(new Leaf("Leaf XYB"));
//root.Add(comp2);

//root.Add(new Leaf("Leaf C"));
//Leaf leaf = new Leaf("Leaf D");
//root.Add(leaf);
//root.Remove(leaf);
//root.Display(1);


