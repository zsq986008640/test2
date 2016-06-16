using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BridgePattern
{
    public abstract class Implementor
    {
        public abstract void Operation();
    }

    public class ConcreteImplementorA : Implementor 
    {
        public override void Operation()
        {
            Console.WriteLine("具体实现A的方法");
        }   
    }
    public class ConcreteImplementorB : Implementor
    {
        public override void Operation()
        {
            Console.WriteLine("具体实现B的方法");
        }
    }

    public abstract class Abstraction 
    {
        protected List<Implementor> list = new List<Implementor>();

        public void Add(Implementor im) 
        {
            list.Add(im);
        }
        public abstract void Operation();
    }

    public class RefinedAbstraction :Abstraction
    {
        public override void Operation()
        {
            if (list.Count > 0) 
            {
                foreach (var item in list)
                {
                    item.Operation();
                }
            }
        }
    
    }

}
