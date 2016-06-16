using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrototypePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //ConcretePrototype1 p1 = new ConcretePrototype1("I");
            //ConcretePrototype1 c1 = (ConcretePrototype1)p1.Clone();
            //Console.WriteLine("Cloned:{0}",c1.Id);

            Resume a = new Resume("赵");
            a.SetPersonInfo("男","29");
            a.SetWorkExperience("2014-2015","邯郸");
            Resume b = (Resume)a.Clone();
            b.SetWorkExperience("2015-2016","北京");
            Resume c = (Resume)b.Clone();
            c.SetPersonInfo("女","24");
            c.SetWorkExperience("2015-2016-7", "北京天相");

            a.Display();
            b.Display();
            c.Display();
            Console.ReadLine();
        }
    }
}
