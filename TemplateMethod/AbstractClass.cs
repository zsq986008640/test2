using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TemplateMethod
{
    public abstract class AbstractClass
    {
        public abstract void PrimitveOperation1();

        public abstract void PrimitveOperation2();

        public void TemplateMethod()
        {
            PrimitveOperation1();
            PrimitveOperation2();
            Console.WriteLine("");
        }
    }

    public class ConcreteClassA : AbstractClass
    {
        public override void PrimitveOperation1()
        {
            Console.WriteLine("具体类A方法1实现");
        }
        public override void PrimitveOperation2()
        {
            Console.WriteLine("具体类A方法1实现");
        }

    }
    public class ConcreteClassB : AbstractClass
    {
        public override void PrimitveOperation1()
        {
            Console.WriteLine("具体类B方法1实现");
        }
        public override void PrimitveOperation2()
        {
            Console.WriteLine("具体类B方法2实现");
        }
    }
}
