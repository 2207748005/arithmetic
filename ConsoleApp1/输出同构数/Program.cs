using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 输出同构数
{
    class Program
    {
        ////编写程序输出 2~99 之间的同构数。同构数是指这个数
        //为该数平方的尾数，例如 5 的平方为 25，6 的平方为 36，25 的平方
        //为 625，则 5、6、25 都为同构数
        static void Main(string[] args)
        {
            for (int i = 2; i <= 99; i++)
            {
                if (NewMethod(i))
                {
                    Console.WriteLine(i+"是同构数");
                }
            }
        }
         static bool NewMethod(int number)
        {
            int pingfang = number * number;
            if (pingfang== (pingfang % 100)* (pingfang % 100) || (pingfang % 10) * (pingfang % 10)==pingfang)
            {
                return true;
            }
            else
            {
                return false;
            }
		}
    }
}
