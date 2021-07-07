using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 输身份证验证性别
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("请输入一个18位身份证号");
                int[] card = new int[18];
                for (int i = 0; i < 18; i++)
                {
                    card[i] = int.Parse(Console.ReadLine());
                    if (card[i]==card[17])
                    {
                        Console.WriteLine("输入完毕");
                        bool bl = card[i].ToString() == "x";
                        Console.WriteLine(bl?'男':'女');
                    }
                }
            }
            catch (Exception e)
            {

                Console.WriteLine(e+"出现错误请关闭重试1");
            }
        }
    }
}
