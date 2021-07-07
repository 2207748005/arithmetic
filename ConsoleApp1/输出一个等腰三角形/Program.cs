using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 输出一个等腰三角形
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("请输入一个大于2小于10的数字：");
                int num = int.Parse(Console.ReadLine());
                if (num<2 || num >10)
                {
                    Console.WriteLine("输入数字有误请重新输入！");
                }
                else
                {
                    //定义变量
                    int i, j, k;
                    for (i = 1; i <= num; i++)
                    {
                        //第一排的空格数就等于输入的数字-1后面把1改成i就表示第几层
                        for (j = 1; j <= num - i; j++)
                        {
                            Console.Write(" ");
                        }
                        //保证打印出来的*为单数
                        for (k = 1; k <= 2 * i - 1; k++)
                        {
                            Console.Write("*");
                        }
                        //空格和**都打印完后换行i++开始下一层
                        Console.WriteLine("\n");
                    }
                }
            }
        }
    }
}
