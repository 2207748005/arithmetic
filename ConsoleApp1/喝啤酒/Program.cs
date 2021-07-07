using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 喝啤酒
{
    class Program
    {
        //啤酒每罐 2.3 元，饮料每罐 1.9 元。小明买了若干啤酒
        //和饮料，一共花了 82.3 元。
        //我们还知道他买的啤酒比饮料的数量少，请你编程计算他买了几罐啤酒。
        //要求：使用循环实现
        static void Main(string[] args)
        {
            //假设部是饮料我们求出饮料的最大数
            int max = Convert.ToInt32(82.3 / 1.9);
            for (int i = 1; i <= max; i++)
            {
                for (int j = 1; j <= max; j++)
                {
                    if (2.3 * i + 1.9 * j == 82.3 && i>j)
                    {
                        
                        Console.WriteLine("啤酒买了"+i+"瓶;饮料买了"+j+"瓶");
                    }
                }
            }
        }
    }
}
