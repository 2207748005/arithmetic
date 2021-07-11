using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 循环输入数组
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[3];
            int max = 0;
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("请输入数字");
                nums[i] = int.Parse(Console.ReadLine());
                if (max<nums[i])
                {
                    max = nums[i];
                }
            }
            
            Console.WriteLine("最大数为："+max);
        }
    }
}
