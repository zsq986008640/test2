using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdpaterPattern
{
    public class Target
    {

        public virtual void Request() 
        {
            Console.WriteLine("普通请求");
        }
    }


    public class Adaptee 
    {
        public void SpecialRequet() 
        {
            Console.WriteLine("特殊请求");
        }
    }

    public class Adpter :Target
    {
        private Adaptee a = new Adaptee();

        public override void Request()
        {
            a.SpecialRequet();
        }
    }
}
