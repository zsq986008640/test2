using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdpaterPattern
{
    public  abstract class Player
    {
        public string Name { get; set; }
        public Player(string name) 
        {
            this.Name = name;
        }

        public abstract void Attack();
        public abstract void Defense();

    }

    public class Forward : Player
    {
        public Forward(string name) : base(name) { }

        public override void Attack()
        {
            Console.WriteLine("前锋，进攻");
        }

        public override void Defense()
        {
            Console.WriteLine("前锋，防御");
        }
    
    }


    public class CentreForward  
    {


        public void SpeakAttack() 
        {
            Console.WriteLine("中锋，进攻");
        }
        public void SpeakDefense() 
        {
            Console.WriteLine("中锋，防御");
        }
    }

    public class Translateor : Player 
    {
        public Translateor(string name) : base(name) { }
        private CentreForward c = new CentreForward();
        public override void Attack()
        {
            c.SpeakAttack();
        }

        public override void Defense()
        {
            c.SpeakDefense();
        }
    }

    public class Guard : Player
    {

        public Guard(string name) : base(name) { }

        public override void Attack()
        {
            Console.WriteLine("后卫，进攻");
        }

        public override void Defense()
        {
            Console.WriteLine("后卫，防御");
        }
    }
    
}
