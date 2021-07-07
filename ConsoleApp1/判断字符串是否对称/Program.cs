using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 判断字符串是否对称
{
    class Program
    {
        //判断一个字符串是否是对称字符串，例如"abc"不是对
        //称字符串，"aba"、"abba"、"aaa"、"mnanm"是对称字符串。是的话
        //输出”Yes”，否则输出”No”
        static void Main(string[] args)
        {
            Console.WriteLine("请输入一个字符串：");
            string str = Console.ReadLine();
            //循环取出
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] !=str[str.Length-1-i])
                {
                    Console.WriteLine("No");
                    return;
                }
                
            }
            Console.WriteLine("Yes");
        }
    }
}
