using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("请输入年：");
            int year=int.Parse( Console.ReadLine());
            Console.Write("请输入月份：");
            int month = int.Parse(Console.ReadLine());
            Console.Write("请输入天");
            int day = int.Parse(Console.ReadLine());
            //用来保存总天数
            int result = 0;
            for (int i = 1; i < month; i++)
            {
                result = result + DateTime.DaysInMonth(year, i);
            }
            result = result + day;
            Console.WriteLine("输入的日期是{0}的第{1}天",year,result.ToString());
            Console.ReadKey();
        }
    }
}
