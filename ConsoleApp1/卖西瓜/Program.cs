using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 卖西瓜
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入瓜重");
            double kg = double.Parse(Console.ReadLine());
            Console.WriteLine("请输入顾客付的钱数");
            double money = double.Parse(Console.ReadLine());
            double yfmoney = 0;
            double change = 0;
            if (kg>20)
            {
                yfmoney = kg * 0.85;
                change = money - yfmoney;
                if (change<0)
                {
                    Console.WriteLine("顾客还需付"+(-change)+"元");
                }
                else
                {
                    Console.WriteLine("找零："+change+"元");
                }
            }
            else if (kg>15 && kg<=20)
            {
                yfmoney = kg * 0.9;
                change = money - yfmoney;
                if (change < 0)
                {
                    Console.WriteLine("顾客还需付" + (-change) + "元");
                }
                else
                {
                    Console.WriteLine("找零：" + change + "元");
                }
            }
            else if (kg>10 && kg<=15)
            {
                yfmoney = kg * 0.95;
                change = money - yfmoney;
                if (change < 0)
                {
                    Console.WriteLine("顾客还需付" + (-change) + "元");
                }
                else
                {
                    Console.WriteLine("找零：" + change + "元");
                }
            }
            else if (kg>5 && kg<=10)
            {
                yfmoney = kg * 1;
                change = money - yfmoney;
                if (change < 0)
                {
                    Console.WriteLine("顾客还需付" + (-change) + "元");
                }
                else
                {
                    Console.WriteLine("找零：" + change + "元");
                }
            }
            else if (kg<5 && kg>=0 )
            {
                yfmoney = kg * 1.05;
                change = money - yfmoney;
                if (change < 0)
                {
                    Console.WriteLine("顾客还需付" + (-change) + "元");
                }
                else
                {
                    Console.WriteLine("找零：" + change + "元");
                }
            }
            else
            {
                Console.WriteLine("输入斤数有误");
            }
        }
    }
}
