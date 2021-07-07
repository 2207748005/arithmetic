using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 输出同构数
{
    class Program
    {
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
            if (number==number*(number%100)|| number == number * (number % 10))
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
