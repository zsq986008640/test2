using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacadePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Facade f = new Facade();
            f.MethodA();
            Console.WriteLine("\t啊建设局建设局\t");
            f.MethodB();
            Console.ReadLine();

        }
    }
}
