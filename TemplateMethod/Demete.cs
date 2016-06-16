using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TemplateMethod
{
  public   class Demete
    {
    }
    //老师
  public class Teacher 
  {
      public void Command(GroupLeader g) 
      {
          g.ShowCount();
      }
  }
    //班长
  public class GroupLeader 
  {
      public List<Girl> list;
      public GroupLeader(List<Girl> list)
      {
          this.list = list;
      }

      public void ShowCount() 
      {
          Console.WriteLine("清点女生的人数为:"+list.Count);
      }
  }
    //女生
  public class Girl 
  {
  
  }
}
