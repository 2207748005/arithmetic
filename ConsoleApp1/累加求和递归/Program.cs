using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 累加求和递归
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(F(100));
        }
        static int F(int n) 
        {
            if (n == 1) return 1;
            return n + F(n - 1);
        }
    }
}
