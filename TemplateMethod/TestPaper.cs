using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TemplateMethod
{
    public class TestPaper
    {

        public void TestQuestion1()
        {
            Console.WriteLine("杨过得到，后来给了郭靖，炼成倚天剑和屠龙刀的肯能是{} a 球墨铸铁 b 马口铁 c 高速合金钢 d碳素纤维");
            Console.WriteLine("答案是:" + Answer1());
        }

        public void TestQuestion2()
        {
            Console.WriteLine("杨过、程英、陆无双铲除了情花，造成【】 a 这种植物不会害人 b 是一种珍稀植物灭绝 c 破坏了那个生物圈的平衡 d 造成该地区沙漠化 ");
            Console.WriteLine("答案是:" + Answer2());
        }

        public void TestQuestion3()
        {
            Console.WriteLine("蓝凤凰致使华山师徒和桃谷六仙呕吐不止，如果你是大夫，你会开什么药{} a 阿司匹林 b 牛黄解毒片 c 氟哌酸 d 让他们和大量的生牛奶 e 以上全都不对 ");
            Console.WriteLine("答案是:" + Answer3());
        }

        public virtual string Answer1()
        {
            return "";
        }
        public virtual string Answer2()
        {
            return "";
        }
        public virtual string Answer3()
        {
            return "";
        }
    }

    public class TestPaperA : TestPaper
    {

        //public TestPaperA() 
        //{
        //    Answer1();
        //    Answer2();
        //    Answer3();
        //}
        public override string Answer1()
        {
            return "A";
        }
        public override string Answer2()
        {
            return "B";
        }

        public override string Answer3()
        {
            return "C";
        }

    }
    public class TestPaperB : TestPaper
    {
        //public TestPaperB()
        //{
        //    Answer1();
        //    Answer2();
        //    Answer3();
        //}
        public override string Answer1()
        {
            return "C";
        }
        public override string Answer2()
        {
            return "A";
        }

        public override string Answer3()
        {
            return "B";
        }

    }

}
