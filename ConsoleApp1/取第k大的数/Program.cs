using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 取第k大的数
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("输入数组长度：");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("输入取第几大的数：");
            int k = int.Parse(Console.ReadLine());
            //定义一个数组
            int[] nums = new int[n];
            //遍历给我们需要的字段里面添加值
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
            }
            //先将数组进行从小到大排序
            Array.Sort(nums);
            //然后在反转变成从大到小
            Array.Reverse(nums);
            //只需要取k-1的值就是我们需要取出来的数字
            Console.WriteLine(nums[k-1]);
        }
    }
}
