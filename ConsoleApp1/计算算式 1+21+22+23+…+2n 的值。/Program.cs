using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 计算算式_1_21_22_23___2n_的值_
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = int.Parse(Console.ReadLine());
            int num = 1;
            for (int i = 1; i <= sum; i++)
            {
                num += (i + 20);
            }
            Console.WriteLine(num);
        }
    }
}
