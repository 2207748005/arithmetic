using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 输入整数_a_输出结果_s_其中_s_与_a_的关系是_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入一个小于10大于1的整数");
            int n = int.Parse(Console.ReadLine());
            //用来接收值
            int s = 0;
            int a=0;
            for (int i = 0; i < n; i++)
            {
                a = a * 10 + n;
                s = s + a;
            }
            Console.WriteLine(s);
        }
    }
}
