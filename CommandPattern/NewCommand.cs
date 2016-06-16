using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommandPattern
{
    public abstract class NewCommand
    {
        protected Receiver receiver;
        public NewCommand(Receiver receiver)
        {
            this.receiver = receiver;
        }
        //执行命令
        public abstract void ExcuteCommand();

    }

    public class Receiver
    {
        public void Action()
        {
            Console.WriteLine("执行请求");
        }
    }


    public class ConcreteCommand : NewCommand 
    {
        public ConcreteCommand(Receiver receiver) : base(receiver) { }

        public override void ExcuteCommand()
        {
            receiver.Action();
        }
    }

    public class Invoker 
    {
        private NewCommand command;
        public void SetCommand(NewCommand command) 
        {
            this.command = command;
        }
        public void ExcecuteCommand() 
        {
            command.ExcuteCommand();
        }
    }

}
