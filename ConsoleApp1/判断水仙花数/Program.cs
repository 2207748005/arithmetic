using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 判断水仙花数
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("请输入一个三位数");
                int num = int.Parse(Console.ReadLine());
                if (num>=100 && num<=999)
                {
                    int x, y, z;
                    x = num / 100;//百位
                    y = num / 10 % 10;//十位
                    z = num % 10;//个位
                    int result = x * x * x + y * y * y + z * z * z;
                    if (result==num)
                    {
                        Console.WriteLine("该数是水仙花数！");
                    }
                    else
                    {
                        Console.WriteLine("该数不是水仙花数！");
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("输入的不符合规则，请重新输入！");
                }
            }
            
        }
    }
}
