using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 递归阶乘
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(F(5).ToString());
            Console.ReadKey();
        }
        //static double f(int n)
        //{
        //    if (n == 1) return 1;
        //    return f(n - 1) + 1.0 / F(n);
        //}
        static int F(int n)
        {
            if (n == 1) return 1;
            return n * F(n - 1);
        }
    }
}
