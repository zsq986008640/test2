using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DEPattern
{
    public abstract class Component
    {
        public abstract void Operation();
    }

    public class ConcreteComponent :Component
    {
        public override void Operation()
        {
            Console.WriteLine("具体对象的操作");
        }
    }

    public abstract class Decorator : Component 
    {
        protected Component component;
        public void SetComponent(Component com) 
        {
            this.component = com;
        }
        public override void Operation()
        {
            if (component != null) 
            {
                component.Operation();
            }
        }
    }


    public class ConcreteDecoratorA : Decorator 
    {
        private string addedState;
        public override void Operation()
        {
            base.Operation();
            addedState = "New State";
            Console.WriteLine("具体装饰对象A的操作");
        }
    }

    public class ConcreteDecoratorB : Decorator 
    {
        public override void Operation()
        {
            base.Operation();
            AddedBehavior();
            Console.WriteLine("具体装饰对象B的操作");
        }

        private void AddedBehavior() 
        {
            
        }
    }









    public class Person 
    {
        public Person() { }

        private string name;
        public Person(string name) 
        {
            this.name = name;
        }
        public virtual void Show() 
        {
            Console.WriteLine("装扮的{0}",name);
        }
    }

    public class Finery : Person 
    {
        protected Person p;
        public void Decorate(Person component) 
        {
            this.p = component;
        }
        public override void Show()
        {
            if(p!=null)
            {
                p.Show();
            }
        }
    }

    public class TShirts : Finery 
    {
        public override void Show()
        {
            Console.WriteLine("大T恤");
            base.Show();
        }
    }

    public class BigTrouser : Finery 
    {
        public override void Show()
        {
            Console.WriteLine("垮裤");
            base.Show();
        }
    }

}
