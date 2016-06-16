using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Composite
{

    public abstract class Component
    {
        protected string name;
        public Component(string name)
        {
            this.name = name;
        }
        public abstract void Add(Component c);
        public abstract void Remove(Component c);
        public abstract void Display(int depth);

    }

    public class Leaf : Component 
    {
        public Leaf(string name) : base(name) 
        {
        
        }

        public override void Add(Component c)
        {
            Console.WriteLine("Cannot add to a leaf");
        }
        public override void Remove(Component c)
        {
            Console.WriteLine("Cannot remove from a leaf");
        }

        public override void Display(int depth)
        {
            //此处显示其名称和级别
            Console.WriteLine(new String('-',depth)+name);
        }
    }


    public class Composite : Component 
    {
        private List<Component> children = new List<Component>();
        public Composite(string name)
            : base(name) 
        { 
        }

        public override void Add(Component c)
        {
            children.Add(c);
        }
        public override void Remove(Component c)
        {
            children.Remove(c);
        }

        public override void Display(int depth)
        {
            //显示其节点名称，并对下级遍历
            Console.WriteLine(new String('-', depth) + name);
            foreach (Component item in children)
            {
                item.Display(depth+2);
            }
        }
    }

}
