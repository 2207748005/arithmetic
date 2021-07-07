using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 求前20个和
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 1;
            double b = 2;
            //保存总数
            double sum = 0;
            for (int i = 0; i < 20; i++)
            {
                sum += b / a;
                //b等于前两个数相加
                b = a + b;
                //a等于前面刚加出来的b减a
                a = b - a;
            }
            Console.WriteLine(sum);
        }
    }
}
