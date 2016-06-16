using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacadePattern
{
    public class SubSystemOne
    {
        public void MethodOne() 
        {
            Console.WriteLine("子系统方法一");
        }

    }
    public class SubSystemTwo
    {
        public void MethodTwo()
        {
            Console.WriteLine("子系统方法二");
        }

    }
    public class SubSystemThree
    {
        public void MethodThree()
        {
            Console.WriteLine("子系统方法三");
        }
    }
    public class SubSystemFour
    {
        public void MethodFour()
        {
            Console.WriteLine("子系统方法四");
        }
    }

    public class Facade 
    {
        SubSystemOne one;
        SubSystemTwo two;
        SubSystemThree three;
        SubSystemFour four;

        public Facade() 
        {
            one = new SubSystemOne();
            two = new SubSystemTwo();
            three = new SubSystemThree();
            four = new SubSystemFour();
        }

        public void MethodA() 
        {
            Console.WriteLine("\n方法组\t");
            one.MethodOne();
            two.MethodTwo();
        }

        public void MethodB() 
        {
            Console.WriteLine("\n方法组");
            three.MethodThree();
            four.MethodFour();
        }

    }

}
