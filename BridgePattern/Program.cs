using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BridgePattern
{
    class Program
    {
        static void Main(string[] args)
        {

            HandSetBrand ab;
            ab = new HandsetBrandN();
            ab.SetHandsetSoft(new HandsetGame());
            ab.Run();

            ab.SetHandsetSoft(new HandsetAddressList());
            ab.Run();

            ab = new HandsetBrandM();
            ab.SetHandsetSoft(new HandsetGame());
            ab.Run();

            ab.SetHandsetSoft(new HandsetAddressList());
            ab.Run();

            Console.WriteLine("------------------------------------------------");
            Abstraction ast;
            ast=new RefinedAbstraction();
            ast.Add(new ConcreteImplementorA());
            ast.Add(new ConcreteImplementorB());
            ast.Operation();

            Console.ReadLine();
        }
    }
}
