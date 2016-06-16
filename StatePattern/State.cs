using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StatePattern
{
    public abstract class State
    {
        public abstract void Handle(Context context);
    }

    public class Context 
    {
        private State state;
        public Context(State state) 
        {
            this.state = state;
        }
        public State State 
        {
            get { return state; }

            set
            { 
                state = value;
                Console.WriteLine("当前状态："+state.GetType().Name);
            }
        }

        public void Request() 
        {
            state.Handle(this);
        }

    }
}
