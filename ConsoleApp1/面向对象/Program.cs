using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 面向对象
{
    class Program
    {
        static void Main(string[] args)
        {
            bigStudent bigstudent = new bigStudent();
            bigstudent.idcard = "1";
            bigstudent.name = "张三";
            bigstudent.major = "软件开发";
        }
    }
    class Student 
    {
       public string idcard;
       public string name;     
    }
    class bigStudent:Student 
    {
        public string major;
    }
}
