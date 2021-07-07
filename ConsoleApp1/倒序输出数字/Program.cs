using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 倒序输出数字
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("请输入一个不多于5位整数");
                int num = int.Parse(Console.ReadLine());
                if ( num >99999)
                {
                    Console.WriteLine("输入的数字不符合规则请重新输入！");
                }
                else
                {
                    string str = num.ToString();
                    Console.WriteLine("长度"+str.Length);
                    //取出字符并存入一个数组中
                    char[] ch = str.ToCharArray();
                    foreach (var item in ch.Reverse())
                    {
                        Console.Write(item);
                    }
                    Console.WriteLine("");
                    break;
                }
            }
           
        }
    }
}
