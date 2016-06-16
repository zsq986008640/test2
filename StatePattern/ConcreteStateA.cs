using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StatePattern
{
    public class ConcreteStateA:State
    {
        public override void Handle(Context context)
        {
            context.State = new ConcreteStateB();
        }

    }
    public class ConcreteStateB : State
    {
        public override void Handle(Context context)
        {
            context.State = new ConcreteStateA();
        }
    }
}
