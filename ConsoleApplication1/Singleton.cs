using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public sealed  class Singleton
    {
        private static Singleton sl;
         private static readonly object syncRoot = new object();
        //构造方法让其private,这就堵死了外界利用New创建此类实例的可能
        private  Singleton()
        {
        
        }
        //此方法是获得本类实例的唯一全局访问点
        public static Singleton GetInstance()
        {
            //这种方法叫双重锁定
            if (sl == null)
            {
                lock (syncRoot)
                {
                    //若实例不存在，则New一个新实例，否则返回已有的实例
                    if (sl == null)
                    {
                        sl = new Singleton();
                    }
                }
            }
            return sl; 
        }
    }
   
    //if (sl == null)
    //{
    //    lock (syncRoot)
    //    {
    //        if (sl == null)
    //        {
    //            sl = new Singleton();
    //        }
    //    }
    //}

}
