using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 判断回文数
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("请输入一个5位数");
                int num = int.Parse(Console.ReadLine());
                if (num<10000 || num>=99999)
                {
                    Console.WriteLine("该数字超出范围请重新输入");
                    
                }
                else
                {
                    int wanwei = num / 10000;//万
                    int qianwei = num / 1000 % 10;//千
                    int baiwei = num / 100 % 10;//百
                    int shiwei = num / 10 % 10;//十
                    int gewei = num % 10;//个
                    if (wanwei==gewei && qianwei==shiwei)
                    {
                        Console.WriteLine("该数字是回文数");
                    }
                    else
                    {
                        Console.WriteLine("改数字不是回文数");
                    }
                    break;
                }
            }
           
        }
    }
}
