using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFP
{
    public class User
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }

    public class Department 
    {
        public int ID { get; set; }
        public string DeptName { get; set; }
    }

    public interface IDepartment 
    {
        void Insert(Department dept);
        Department GetDepartment(int id);
    }
    public interface IUser 
    {
        void Insert(User user);
        User GetUser(int id);
    }

    public class SqlserverUser :IUser
    {
        public void Insert(User user) 
        {
            Console.WriteLine("在SQL Server中给User表增加一条记录");
        }

        public User GetUser(int id)
        {
            Console.WriteLine("在SQL Server中根据ID 得到User表一条记录");
            return null;
        }
    }

    public class AccessUser : IUser 
    {
        public void Insert(User user)
        {
            Console.WriteLine("在Access中给User表增加一条记录");
        }

        public User GetUser(int id)
        {
            Console.WriteLine("在Access中根据ID 得到User表一条记录");
            return null;
        }
    }


    public class SqlserverDepartment : IDepartment 
    {
        public void Insert(Department dept) 
        {
            Console.WriteLine("向Sql server数据库中往表Department添加一条数据");
        }

        public Department GetDepartment(int id) 
        {
            Console.WriteLine("在Sqlserver 中根据ID 得到Department表一条记录");
            return null;
        }
    }

    public class AccessDepartment : IDepartment 
    {
        public void Insert(Department dept)
        {
            Console.WriteLine("向Access数据库中往表Department添加一条数据");
        }

        public Department GetDepartment(int id)
        {
            Console.WriteLine("在Access 中根据ID 得到Department表一条记录");
            return null;
        }
    }
}
