using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MementoPattern
{
    //发起人
    public class Originator
    {
        public string State { get; set; }

        //创建备忘录，将当前需要保存的信息导入并实例化出一个Memento对象
        public Memento CreateMemento() 
        {
            return (new Memento(State));
        }
        //恢复备忘录，将Memento导入并将相关数据恢复
        public void SetMemento(Memento m) 
        {
            State = m.State;
        }
        //显示数据
        public void show() 
        {
            Console.WriteLine("State="+State);
        }
    }
    //备忘录
    public class Memento 
    {
        private string state;

        public string State 
        {
            get 
            {
                return state;
            }
        }
        public Memento(string state) 
        {
            this.state = state;
        }
    }

    //管理者
    public class Caretaker 
    {
        public Memento memento { get; set; }
    }
}
