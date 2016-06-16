using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommandPattern
{
    //烤肉串者
    public class Barbecuer
    {
        //烤羊肉
        public void BakeMutton()
        {
            Console.WriteLine("烤羊肉串");
        }
        //烤鸡翅
        public void BakeChickenWing()
        {
            Console.WriteLine("烤鸡翅");
        }
    }

    //抽象命令
    public abstract class Command
    {
        protected Barbecuer receiver;
        public Command(Barbecuer receiver) 
        {
            this.receiver = receiver;
        }
        //执行命令
        public abstract void ExcuteCommand();
    }

    //具体命令
    //烤羊肉串命令
    public class BakeMuttonCommand : Command
    {
        public BakeMuttonCommand(Barbecuer receiver) : base(receiver) { }

        public override void ExcuteCommand()
        {
            receiver.BakeMutton();
        }
    }

    //烤鸡翅命令
    public class BakeChickenWingCommand : Command 
    {
        public BakeChickenWingCommand(Barbecuer receiver) : base(receiver) { }
        public override void ExcuteCommand()
        {
            receiver.BakeChickenWing();
        }
    }

    //服务员类
    public class Waiter 
    {
        private List<Command> orders = new List<Command>();

        //设置顶大
        public void SetOrder(Command command)
        {
            if (command.ToString() == "CommandPattern.BakeChickenWingCommand")
            {
                Console.WriteLine("服务员：鸡翅没了，清点别的烧烤");
            }
            else 
            {
                orders.Add(command);
                Console.WriteLine("增加订单："+command.ToString()+"  时间："+DateTime.Now.ToString());
            } 
        }

        //取消订单
        public void CancelOrder(Command command) 
        {
            orders.Remove(command);
        }

        //通知全部执行
        public void Notify() 
        {
            foreach (var item in orders)
            {
                item.ExcuteCommand();
            }
        }
        //private Command command;
        ////设置订单
        //public void SetOrder(Command command)
        //{
        //    this.command = command;
        //}

        ////通知执行
        //public void Notify() 
        //{
        //    command.ExcuteCommand();
        //}
    }

}
