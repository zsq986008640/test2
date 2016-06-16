using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            //Barbecuer boy = new Barbecuer();
            //Command bakeMuttonCommand1 = new BakeMuttonCommand(boy);
            //Command bakeMuttonCommand2 = new BakeMuttonCommand(boy);
            //Command bakeChicken = new BakeChickenWingCommand(boy);

            //Waiter girl = new Waiter();

            //girl.SetOrder(bakeMuttonCommand1);
        
            //girl.SetOrder(bakeMuttonCommand2);
  
            //girl.SetOrder(bakeChicken);
            //girl.Notify();


            Receiver r = new Receiver();
            NewCommand nc = new ConcreteCommand(r);
            Invoker i = new Invoker();
            i.SetCommand(nc);
            i.ExcecuteCommand();
            Console.ReadLine();
        }
    }
}
 