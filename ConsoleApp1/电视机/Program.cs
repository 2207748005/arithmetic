using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 电视机
{
    class Program
    {
        //某电视机厂每天生产电视 500 台，在质量评比中，每生
        //产一台合格电视机记 5 分，每生产一台不合格电视机扣 18 分。如果
        //四天得了 9931 分，编程计算这四天生产的合格电视机的台数，并输
        //出。
        //要求： 用循环语句实现
        static void Main(string[] args)
        {
            //4天共生产result台
            int result = 500 * 4;
            //
            for (int i = 0; i < result; i++)
            {
                for (int j = 0; j < result; j++)
                {
                    
                    if (i * 5 - j * 18==9931 && i + j==2000)
                    {
                        Console.WriteLine("合格"+i+"台;不和格"+j+"台");
                    }
                }
            }
        }
    }
}
