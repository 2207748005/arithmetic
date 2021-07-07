using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 阶乘
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(F(5));
        }

        static int F(int n) 
        {
            if (n==1)
            {
                return 1;
            }
            else
            {
                return n * F(n - 1);
            }
        }
    }
}
