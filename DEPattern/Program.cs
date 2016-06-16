using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DEPattern
{
    class Program
    {
        static void Main(string[] args)
        {
        //    ConcreteComponent c = new ConcreteComponent();
        //    ConcreteDecoratorA a = new ConcreteDecoratorA();
        //    ConcreteDecoratorB b = new ConcreteDecoratorB();
        //    a.SetComponent(c);

        //    b.SetComponent(a);
        //    b.Operation();


            //人 穿 衣服  裤子  皮鞋
            //装饰模式
            


            Person xc=new Person ("小菜");
            TShirts tx = new TShirts();
            BigTrouser bg = new BigTrouser();

            tx.Decorate(xc);
            bg.Decorate(tx);
            bg.Show();
            Console.ReadLine();
        }
    }

    ////具体类
    //public class Person1
    //{
    //    public string Name{get;set;}
    //    public Person1(string name)
    //    {
    //        this.Name=name;
    //    }
    //    public virtual void Show()
    //    {
    //        Console.WriteLine("装扮的{0}", Name);
    //    }
    //}

    ////装饰类
    //public class Decorator1 :Person1
    //{
    //    protected Person1 p;
    //    public void Decorate1(Person1 p)
    //    {
    //        this.p = p;
    //    }
    //    public override void Show()
    //    {
    //        if (p != null) 
    //        {
    //            p.Show();
    //        }
    //    }
        
    //}

}
