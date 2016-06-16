using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StatePattern
{
    public class Work
    {
        public double Hour { get; set; }
        public bool IsComplected { get; set; }
        private WorkState state;
        public Work(WorkState state) 
        {
            this.state = state;
        }

        public void SetState(WorkState s) 
        {
            this.state = s;
        }

        public void DoCode() 
        {
            this.state.DoCode(this);
        }
         
    }

    public abstract class WorkState 
    {
        public abstract void DoCode(Work w);
    }


    //public interface animal 
    //{
    //    void Action();
    //    void Eat();
    //}

    //public class Cat : animal
    //{
    //    public void Action()
    //    {
    //        Console.WriteLine("ssss");
    //    }
    //}

}
