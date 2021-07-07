using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 分割单词存入数组
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入一个字符串");
            string str = Console.ReadLine();
            
            string[] s= str.Split(new char[] { ' '});
            foreach (var item in s)
            {
                Console.WriteLine(item);
            }
        }
    }
}
