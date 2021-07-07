using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 计算数组的最大值最小值和平均值
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] array = { 9.8, 12, 45, 67, 23, 1.98, 2.55, 45 };
            Console.WriteLine("最大值"+array.Max());
            Console.WriteLine("最小值"+array.Min());
            Console.WriteLine("平均值"+array.Average());
        }
    }
}
