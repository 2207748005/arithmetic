using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 输入小写123转大写一二三
{
    class Program
    {
        static void Main(string[] args)
        {
            // 录入数字
            string num;
            Console.Write("请输入数字：");
            num = Console.ReadLine();
            try
            {
                Convert.ToInt32(num);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

            // 定义中文数字
            string[] arr = { "零", "一", "二", "三", "四", "五", "六", "七", "八", "九" };

            // 打印
            foreach (char item in num)
            {
                Console.Write(arr[Convert.ToInt32(item.ToString())]);
            }
        }
    }
}
