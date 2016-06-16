using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MementoPattern
{
    //发起类
    public class GameRole
    {
        //生命力
        public int Vit { get; set; }
        //攻击力 
        public int Attack { get; set; }
        //防御力
        public int Defense { get; set; }

        //创建备忘录
        public GameMemento CreateMemento() 
        {
            return (new GameMemento(Vit,Attack,Defense));
        }
        //大战Boss
        public void Fight() 
        {
            Vit = 0;
            Attack = 0;
            Defense =0;
        }
        //恢复备忘录
        public void SetMemento(GameMemento m) 
        {
            this.Vit = m.Vit;
            this.Attack = m.Attack;
            this.Defense = m.Defense;
        }
        //展示
        public void Show() 
        {
            Console.WriteLine("当前生命力：{0}",Vit);
            Console.WriteLine("当前攻击力：{0}", Attack);
            Console.WriteLine("当前防御力：{0}", Defense);
        }
    }

    //游戏备录类
    public class GameMemento 
    {
        private int vit;
        private int att;
        private int def;

        public GameMemento(int vit,int att,int def) 
        {
            this.vit = vit;
            this.att = att;
            this.def = def;
        }

        public int Vit 
        {
            get { return vit; }
        }

        public int Attack 
        {
            get { return att; }
        }
        public int Defense 
        {
            get { return def; }
        }
    }

    //游戏管理者
    public class GameCaretaker 
    {
        public GameMemento gameMemento { get; set; }
    }


}
