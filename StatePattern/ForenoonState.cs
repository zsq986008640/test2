using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StatePattern
{
    //早上工作
    public class ForenoonState:WorkState
    {
        public override void DoCode(Work w)
        {
            if (w.Hour < 12)
            {
                Console.WriteLine("当前时间{0}点，上午工作中。", w.Hour);
            }
            else 
            {
                w.SetState(new NoonState()); w.DoCode();
            }
        }
    }
    //中午工作
    public class NoonState : WorkState 
    {
        public override void DoCode(Work w)
        {
            if (w.Hour < 13)
            {
                Console.WriteLine("当前时间{0}点，中午工作中。", w.Hour);
            }
            else
            {
                w.SetState(new AfterNoonState()); w.DoCode();
            }
        }    
    }
    //下午工作
    public class AfterNoonState : WorkState 
    {
        public override void DoCode(Work w)
        {
            if (w.Hour < 18)
            {
                Console.WriteLine("当前时间{0}点，下午工作中。", w.Hour);
            }
            else
            {
                w.SetState(new EveningState()); w.DoCode();
            }
        }    
    }
    //晚上
    public class EveningState : WorkState 
    {
        public override void DoCode(Work w)
        {
            if (w.IsComplected) 
            {
                w.SetState(new RestState()); w.DoCode();
            }
            else
            {
                if (w.Hour < 20)
                {
                    Console.WriteLine("当前时间{0}点，晚上工作中。", w.Hour);
                }
                else
                {
                    w.SetState(new RestState()); w.DoCode();
                }
            }
        }
    }


    //睡眠状态
    public class SleepingState : WorkState 
    {
        public override void DoCode(Work w)
        {
            Console.WriteLine("当前时间{0}，不行了，脑子好痛，我要睡了",w.Hour);
        }
    }

    //下班休息状态
    public class RestState : WorkState 
    {
        public override void DoCode(Work w)
        {
            Console.WriteLine("当前时间{0}，下班回家，走人", w.Hour);
        }
    }

}
