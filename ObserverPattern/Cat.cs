using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObserverPattern
{
    //猫叫一声   老鼠跑     人醒了 

    public interface ITalk
    {
        string Name { get; set; }
        void Talk();
    }
    public class Cat : ITalk
    {
        public delegate void Handle();
        public event Handle Action;
        public string Name { get; set; }

        List<CatObserver> list = new List<CatObserver>();

        public void Add(CatObserver ob)
        {
            list.Add(ob);
        }

        public void Show()
        {
            Console.WriteLine("老猫叫了，老猫的名字是:{0}", Name);
            foreach (var item in list)
            {
                item.Act();
            }
        }

        public Cat(string name)
        {
            Name = name;
        }

        public void Talk()
        {
            Console.WriteLine("老猫叫了，老猫的名字是:{0}", Name);
            if (Action != null) 
            {
                Action();
            }
        }
    }

    public abstract class CatObserver 
    {
        public  string Name{get;set;}
        
        public CatObserver(ITalk ita) 
        {
            this.Name = ita.Name;
        }
        public abstract void Act();
    }

    public class Mouse:CatObserver
    {
        public Mouse(ITalk ita) : base(ita) 
        {
        
        }
        public override void Act()
        {
            Console.WriteLine("{0}把老鼠吓跑了", Name);
        }
    }

    public class Person:CatObserver
    {
        public Person(ITalk ita)
            : base(ita)
        {
    
        }
        public override void Act()
        {
            Console.WriteLine("该死的{0},把我叫醒了",Name);
        }
    }

}
