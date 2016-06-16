using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObserverPattern
{
    //通知者接口
   public  interface Subject
    {
        void Notify();
        string SubjectState{get;set;}
    }

    //看股票的同事
    public class StockObserver
    {
        private string name;
        private Subject sub;
        public StockObserver(string name, Subject sub) 
        {
            this.name = name;
            this.sub = sub;
        }

        public void CloseStockMarket() 
        {
            Console.WriteLine("{0} {1}关闭股票行情，继续工作!",sub.SubjectState,name);
        }
    }
    //看NBA的同事
    public class NBAObserver 
    {
        private string name;
        private Subject sub;
        public NBAObserver(string name, Subject sub)
        {
            this.name = name;
            this.sub = sub;
        }

        public void CloseNBADirectSeeding()
        {
            Console.WriteLine("{0} {1}关闭NBA直播，继续工作!", sub.SubjectState, name);
        }
    }

   
   
    public class Boss : Subject 
    {
        public delegate void EventHan();
        public event EventHan Update;
        public string SubjectState { get; set; }

        public void Notify() 
        {
            Update();
        }
    }

    //public abstract class Subject 
    //{
    //    List<Observer> list = new List<Observer>();
    //    public void Add(Observer obser) 
    //    {
    //        list.Add(obser);
    //    }
    //    public void Detach(Observer obser) 
    //    {
    //        list.Add(obser);
    //    }

    //    public void Notify() 
    //    {
    //        foreach (var item in list)
    //        {
    //            item.Update();
    //        }
    //    }
    //}

    //public abstract class Observer 
    //{
    //    public abstract void Update();
    //}


    //public class ConcreteSubject : Subject 
    //{
    //    public string SubjectState { get; set; }
    //}

    //public class ConcreteObserver : Observer 
    //{
    //    private string name;
    //    private string observerState;
    //    private ConcreteSubject subject;

    //    public ConcreteObserver(ConcreteSubject subject, string name)
    //    {
    //        this.name = name;
    //        this.subject = subject;
    //    }

    //    public override void Update()
    //    {
    //        observerState = subject.SubjectState;
    //        Console.WriteLine("观察者{0}的新状态{1}",name,observerState);
    //    }
    //    public ConcreteSubject Subject 
    //    {
    //        get { return subject; }
    //        set { subject = value; }
    //    }
    //}


    #region 观察者模式


    // //观察者抽象类
    // public abstract class Observer 
    // {
    //     protected string name;
    //     protected Subject sub;
    //     public Observer(string name, Subject sub) 
    //     {
    //         this.name = name;
    //         this.sub = sub;
    //     }
    //     public abstract void Update();
    // }

    // //通知者接口
    //public  interface Subject 
    // {
    //    void Add(Observer observer);
    //     void Detach(Observer observer);
    //     void Notify();
    //     string SubjectState { get; set; }
    // }

    // public class Boss : Subject 
    // {
    //     //同事列表
    //     private List<Observer> observers = new List<Observer>();

    //     //增加同事
    //     public void Add(Observer observer)
    //     {
    //         observers.Add(observer);
    //     }

    //     //通知
    //     public void Notify()
    //     {
    //         foreach (var item in observers)
    //         {
    //             item.Update();
    //         }
    //     }
    //     //减少
    //     public void Detach(Observer observer) 
    //     {
    //         observers.Remove(observer);
    //     }

    //     //前台状态
    //     public string SubjectState { get; set; }
    // }

    // public class Secretary:Subject
    // {
    //    //同事列表
    //     private List<Observer> observers = new List<Observer>();

    //     //增加同事
    //     public void Add(Observer observer)
    //     {
    //         observers.Add(observer);
    //     }
    //     //减少同事
    //     public void Detach(Observer observer) 
    //     {
    //         observers.Remove(observer);
    //     }

    //     //通知
    //     public void Notify() 
    //     {
    //         foreach (var item in observers)
    //         {
    //             item.Update();
    //         }
    //     }
    //     //前台状态
    //     public string SubjectState { get; set; }
    // }

    //  public class StockObserver :Observer
    //  {
    //      public StockObserver(string name, Subject sub) : base(name, sub) 
    //      {         
    //      }

    //      public override void Update() 
    //      {
    //          Console.WriteLine("{0},{1} 关闭股票行情，继续工作", sub.SubjectState, name);
    //      }
    //  }

    //  public class NBAObserver : Observer 
    //  {
    //      public NBAObserver(string name, Subject sub)
    //          : base(name, sub) 
    //      {

    //      }
    //      public override void Update()
    //      {
    //          Console.WriteLine("{0},{1} 关闭NBA直播，继续工作", sub.SubjectState, name);
    //      }

    //  }
    #endregion

}
