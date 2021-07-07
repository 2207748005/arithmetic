using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 乘法
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 9; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    int sum = i * j;
                    Console.Write(j+"*"+i+"="+sum+"\t");
                }
                Console.WriteLine("");
            }
        }
    }
}
