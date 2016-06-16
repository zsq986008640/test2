using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BridgePattern
{
    //手机软件
    public abstract class HandsetSoft
    {
        public abstract void Run();
    }

    //手机游戏
    public class HandsetGame : HandsetSoft
    {
        public override void Run()
        {
            Console.WriteLine("运行手机游戏");
        }
    }

    //手机通讯录
    public class HandsetAddressList : HandsetSoft 
    {
        public override void Run()
        {
            Console.WriteLine("运行手机通讯录");
        }
    }



    //手机品牌
    public abstract class HandSetBrand 
    {
        protected HandsetSoft soft;
        public void  SetHandsetSoft(HandsetSoft soft)
        {
            this.soft = soft;
        }

        public abstract void Run();
    }

    public class HandsetBrandN : HandSetBrand  
    {
        public override void Run()
        {
            soft.Run();
        }
    }

    public class HandsetBrandM : HandSetBrand 
    {
        public override void Run()
        {
            soft.Run();
        }
    }

}
