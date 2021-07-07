using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 用输出一个矩形
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("请输入一个整数：");
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                for (int j = 0; j < num; j++)
                {
                    //只要x或y轴的下标为最小位或者最大位，打印*号，否则打印空格
                    //总体思路还是看他的下标，反正只要是最后一个或者第一个输出，不管你是横排还是竖排都是要输出一个*
                    if (i == 0 || j == 0 || i == (num - 1) || j == (num - 1))
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }

                }
                Console.WriteLine("");
            }
        }
    }
}
