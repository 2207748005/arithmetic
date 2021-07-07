using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 计算图书的总价格
{
    class Program
    {
        //编写程序计算购买图书的总价格：用户输入图书的定价
        //和购买图书的数量，并分别保存到一个 float 和一个 int 类型的变量中，
        //然后根据用户输入的定价和购买图书的数量，计算合计购书金额并输
        //出。其中，图书销售策略为：正常情况下按 9 折出售，购书数量超过
        //10 本打 85 折，超过 100 本打 8 折
        static void Main(string[] args)
        {
            Console.WriteLine("请输入图书价格：");
            float money = float.Parse(Console.ReadLine());
            Console.WriteLine("请输入您购买的数量：");
            int num = int.Parse(Console.ReadLine());
            if (num<10)
            {
                Console.WriteLine("宁需要付"+num*money*0.9);
            }
            else if (num>=10 && num <100)
            {
               Console.WriteLine("宁需要付" + num * money * 0.85);
            }
            else if (num>=100)
            {
                Console.WriteLine("宁需要付" + num * money * 0.8);
            }
            else
            {
                Console.WriteLine("输入有误！");
            }
        }
    }
}
