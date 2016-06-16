using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdpaterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //Target t = new Adpter();
            //t.Request();

            Player qian = new Forward("麦迪");

            Player zhong = new Translateor("姚明");
            Player hou = new Guard("保罗");

            qian.Attack();
            qian.Defense();

            zhong.Attack();
            zhong.Defense();

            hou.Attack();
            hou.Defense();

            Console.ReadLine();

        }
    }
}
