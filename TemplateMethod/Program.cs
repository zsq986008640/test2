using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            //TestPaper a = new TestPaperA();
            //TestPaper b = new TestPaperB();

            //a.TestQuestion1();
            //a.TestQuestion2();
            //a.TestQuestion3();

            //b.TestQuestion1();
            //b.TestQuestion2();
            //b.TestQuestion3();

            //AbstractClass a = new ConcreteClassA();
            //AbstractClass b = new ConcreteClassB();
            //a.TemplateMethod();
            //b.TemplateMethod();

            List<Girl> list = new List<Girl>();
            for (int i = 0; i < 10; i++)
            {
                list.Add(new Girl());
            }

            GroupLeader g = new GroupLeader(list);
            Teacher t = new Teacher();
            t.Command(g);
            Console.ReadLine();
            
        }
    }
}
