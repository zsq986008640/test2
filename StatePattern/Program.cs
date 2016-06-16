using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //Context c = new Context(new ConcreteStateA());
            //c.Request();
            //c.Request();
            //c.Request();
            //c.Request();

            //Console.ReadLine();
            //Console.WriteLine();

            Work w = new Work(new ForenoonState());
            w.Hour = 10;
            w.DoCode();
            w.Hour = 12;
            w.DoCode();
            w.Hour = 16;
            w.DoCode();
            w.Hour = 18;
            w.IsComplected = true;
            w.DoCode();
            //w.Hour = 12;
        
            Console.ReadLine();
        }
    }
}
