using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace ConsoleApplication2
{
    public class MyClass   
    {
        public string m;
        public void Test(){}
        public int MyProperty { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
           // Type type = typeof(MyClass);
           //Console.WriteLine("类型名:" + type.Name);
           //Console.WriteLine("<br/>");
           //Console.WriteLine("类全名：" + type.FullName);
           //Console.WriteLine("<br/>");
           //Console.WriteLine("命名空间名:" + type.Namespace);
           //Console.WriteLine("<br/>");
           //Console.WriteLine("程序集名：" + type.Assembly);
           //Console.WriteLine("<br/>");
           //Console.WriteLine("模块名:" + type.Module);
           //Console.WriteLine("<br/>");
           //Console.WriteLine("基类名：" + type.BaseType);
           //Console.WriteLine("<br/>");
           //Console.WriteLine("是否类：" + type.IsClass);
           //Console.WriteLine("<br/>");
           //Console.WriteLine("类的公共成员：");
           //Console.WriteLine("<br/>");
           //  MemberInfo[] memberInfos = type.GetMembers();//得到所有公共成员
           //  foreach (var item in memberInfos)
           //  {
           //    Console.WriteLine(string.Format("{0}:{1}", item.MemberType, item));
           //    Console.WriteLine("<br/>");
           //  }

            //获取当前代码的程序集
            Assembly assem = Assembly.GetExecutingAssembly();
            Console.WriteLine("程序集全名："+assem.FullName);
            Console.WriteLine("程序集名称：" + assem.GetName().Name);
            Console.WriteLine("程序集版本：" + assem.GetName().Version);
            Console.WriteLine("程序集初始位置：" + assem.CodeBase);
            Console.WriteLine("程序集位置：" + assem.Location);
            Console.WriteLine("程序集入口：" + assem.EntryPoint);
            Type[] types = assem.GetTypes();
            Console.WriteLine("程序集下包含的类型:");
            foreach (var item in types)
            {
           
                Console.WriteLine("类：" + item.Name);
            }
             Console.ReadLine();
        }
    }
}
