using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFP
{
    class Program
    {
        static void Main(string[] args)
        {
            //DateTime dt = GetFriday(DateTime.Now.AddDays(3));


            //while (true)
            //{
            //    Console.WriteLine("请输入一个1-100的数字？");
            //    int num = int.Parse(Console.ReadLine());
            //    double rate = 1;
            //    if (num >= 15)
            //    {
            //        for (int i = 25; i < num; i += 5)
            //        {
            //            //    if (num - 15 <= 10)
            //            //    {
            //            //        rate = 1;
            //            //    }

            //            rate = rate - 0.1;
            //        }
            //    }
            //    else 
            //    {
            //        for (int i = 15; i > num; i-=3)
            //        {
            //            rate = rate + 0.1;
            //        }
            //    }
            //    Console.WriteLine(rate);
            //}


            //User user = new User();
            //Department dept = new Department();

            //IFactory factory = new SqlServerFactory();
            //IUser suser = factory.CreateUser();
            //IDepartment sdept = factory.CreateDepartment();
            //suser.Insert(user);
            //suser.GetUser(1);
            //sdept.Insert(dept);
            //sdept.GetDepartment(1);

            //IFactory ft = new AccessFactory();
            //IUser access = ft.CreateUser();
            //IDepartment adept = ft.CreateDepartment();
            //access.Insert(user);
            //access.GetUser(133);
            //adept.Insert(dept);
            //adept.GetDepartment(1);

            User u = new User();
            IUser sql = SimpleFactory.CreateUser();
            sql.Insert(u);
            sql.GetUser(1);
            Console.ReadLine();
        }



        public static DateTime GetFriday(DateTime date)
        {
            int dow = (int)date.DayOfWeek;
            if (dow == 0)
            {
                return date.AddDays(-2);
            }
            else
            {
                return date.AddDays(5 - dow).AddDays(-7);
            }

        }
    }
}
