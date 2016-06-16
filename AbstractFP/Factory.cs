using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Configuration;

namespace AbstractFP
{
    public interface IFactory 
    {
        IUser CreateUser();
        IDepartment CreateDepartment();
    }


    public class SimpleFactory 
    {
        private static readonly string AssemblyName = "AbstractFP";
        private static readonly string db = ConfigurationManager.AppSettings["DB"];
       // IUser result = (IUser)Assembly.Load(AssemblyName).CreateInstance("抽象工厂模式.SqlserverUser");
     
        public static IUser CreateUser() 
        {
            //获取本类的程序集名称
            string Name = typeof(SimpleFactory).Assembly.GetName().Name;
            string className = AssemblyName + "." + db + "User";
            return (IUser)Assembly.Load(AssemblyName).CreateInstance(className) ;
        }

        public static IDepartment CreateDepartment() 
        {
            string className = AssemblyName + "." + db + "Department";
            return (IDepartment)Assembly.Load(AssemblyName).CreateInstance(className);
        }
    }

    public class SqlServerFactory : IFactory
    {
        public IUser CreateUser() 
        {
            return new SqlserverUser();
        }

        public IDepartment CreateDepartment() 
        {
            return new SqlserverDepartment();
        }

    }
    public class AccessFactory : IFactory 
    {
        public IUser CreateUser()
        {
            return new AccessUser();
        }
        public IDepartment CreateDepartment()
        {
            return new AccessDepartment();
        }
    }

}
