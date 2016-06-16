using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MementoPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            Originator o = new Originator();
            o.State = "ON";
            o.show();

            //保存状态
            Caretaker c = new Caretaker();
            c.memento = o.CreateMemento();

            o.State = "Off";
            o.show();
            //恢复原始状态
            o.SetMemento(c.memento);
            o.show();


            Console.WriteLine();
            GameRole g = new GameRole();
            g.Vit = 50;
            g.Attack = 70;
            g.Defense = 60;

            g.Show();
            //保存进度
            GameCaretaker gm = new GameCaretaker();
            gm.gameMemento = g.CreateMemento();
            //打Boss
            g.Fight();
            g.Show();
            //恢复之前状态
            g.SetMemento(gm.gameMemento);
            g.Show();
            Console.ReadLine();

        }
    }
}

  
