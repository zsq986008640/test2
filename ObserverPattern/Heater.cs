using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObserverPattern
{

    // 假设我们有个高档的热水器，我们给它通上电，当水温超过95度的时候：1、扬声器会开始发出语音，告诉你水的温度；2、液晶屏也会改变水温的显示，来提示水已经快烧开了。
    //现在我们需要写个程序来模拟这个烧水的过程，我们将定义一个类来代表热水器，我们管它叫：Heater，它有代表水温的字段，
    //叫做temperature；当然，还有必不可少的给水加热方法BoilWater()，一个发出语音警报的方法MakeAlert()，一个显示水温的方法，ShowMsg()。
    public class Heater
    {
        public delegate void EventHandle();
        public event EventHandle Boil;
        public int Temperature { get; set; }

        public Heater(int temp)
        {
            this.Temperature = temp;
        }

        public void BoilWater()
        {
            if (Temperature > 95)
            {
                Boil();
            }
        }
    }


    public abstract class  ChouAct
    {
        protected Heater h;
        public ChouAct(Heater h)
        {
            this.h = h;
        }
       public abstract void Act();
    }

    public class LoudSpeaker : ChouAct
    {
        public LoudSpeaker(Heater h) : base(h) { }

        public override void Act()
        {
            Console.WriteLine("我是扬声器，水已经烧开了,水温{0}度", h.Temperature);
        }
    }

    public class LCD : ChouAct
    {
        public LCD(Heater h) : base(h) { }

        public override void Act()
        {
            Console.WriteLine("我是液晶屏，水已经烧开了,当前指示灯为红色");
        }
    }

}
