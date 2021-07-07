using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 计算平方根
{
    class Program
    {
        //求 n 以内（不包括 n）同时能被 3 和 7 整除的所有自然
        //数之和的平方根 s，然后将结果 s 输出。例如若 n 为 1000 时，则
        //s = 153.909064。
        //要求：使用循环语句结构实现。 ②n 由键盘输入，且 100 ≤ n ≤
        //10000
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("请输入一个大于100小于10000的数");
                int n = int.Parse(Console.ReadLine());
                int sum = 0;
                double s ;
                if (100 <= n && n <= 1000)
                {
                    for (int i = 0; i < n; i++)
                    {
                        if (i % 3 == 0 && i % 7 == 0)
                        {
                            sum += i;
                        }
                    }
                    s = Math.Sqrt(sum);
                    Console.WriteLine(s);
                    break;
                }
                else
                {
                    break;
                }
            }
        }
    }
}
