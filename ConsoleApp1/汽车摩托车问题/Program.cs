using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 汽车摩托车问题
{
    class Program
    {
        static void Main(string[] args)
        {
            //已知条件
            for (int i = 1; i <= 48; i++)
            {
                for (int j = 1; j <=48; j++)
                {
                    if (4*i + 3*j == 172 && i+j == 48)
                    {
                        Console.WriteLine("摩托车有"+j+"辆；"+"汽车有"+i);
                    }
                }
            }
        }
    }
}
