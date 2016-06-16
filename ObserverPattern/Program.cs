using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ObserverPattern
{
    public class Number 
    {
        public int NumA { get; set; }
        public int NumB { get; set; }
    }

    class Program
    {

        static void Main(string[] args)
        {

            //Subject huhansan = new Boss();

            //Observer tongshi1 = new StockObserver("魏冠子",huhansan);
            //Observer tongshi2 = new NBAObserver("宋青书",huhansan);

            //huhansan.SubjectState = "我胡汉三又回来了";

            //huhansan.Add(tongshi1);
            //huhansan.Add(tongshi2);
            //huhansan.Notify();


            //ConcreteSubject s = new ConcreteSubject();
            //s.Add(new ConcreteObserver(s,"X"));
            //s.Add(new ConcreteObserver(s,"Y"));
            //s.Add(new ConcreteObserver(s,"ABC"));

            //s.SubjectState = "王大锤";
            //s.Notify();


            Boss laoban = new Boss();
            StockObserver togshi1 = new StockObserver("小赵", laoban);
            NBAObserver toshi2 = new NBAObserver("小韩", laoban);
            laoban.Update += new ObserverPattern.Boss.EventHan(togshi1.CloseStockMarket);
            laoban.Update += toshi2.CloseNBADirectSeeding;
            laoban.SubjectState = "本大老板又回来了";
            laoban.Notify();

            //Cat cat = new Cat("福寿");

            //CatObserver mouse = new Mouse(cat);
            //CatObserver person = new Person(cat);

            //cat.Add(mouse);
            //cat.Add(person);
            //cat.Show();

            //Mouse m = new Mouse(cat);
            //Person p = new Person(cat);

            // cat.Action+=new Cat.Handle(m.Run);
            // cat.Action += new Cat.Handle(p.Weak);
            // cat.Talk();


            //Heater h = new Heater(100);
            //ChouAct loud = new LoudSpeaker(h);
            //ChouAct lcd = new LCD(h);
            //h.Boil+=new Heater.EventHandle(loud.Act);
            //h.Boil += new Heater.EventHandle(lcd.Act);
            //h.BoilWater();

            //List<int> list = new List<int>();
            //list.Add(20160520);
            //list.Add(20160521);
            //string TimeCollect = "";
            //foreach (var item in list)
            //{
            //    TimeCollect += item + " ";
            //}

            //string body = string.Format("美元外汇插入{0}条数据,数据日期为{1}", list.Count, TimeCollect);
            //Console.WriteLine(body);
            try
            {
                Thread t = new Thread(SendMail);
                t.Start();

            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }

        public static  void SendMail() 
        {
            string str = "zhao1234";
            int wo = Convert.ToInt32(str);

        }
    }
}
