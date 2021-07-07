using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 连尾号
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("请输入一个手机号：");
                string phone = Console.ReadLine();
                if (phone.Length != 11)
                {
                    Console.WriteLine("输入手机号各式有误！");
                }
                else
                {
                    
                    if (phone[0].ToString()=="1")
                    {
                        if (phone[1].ToString()=="3" || phone[1].ToString() == "5" || phone[1].ToString() == "8")
                        {
                            Console.WriteLine(phone[2]);
                            foreach (var item in phone.Substring(6))
                            {
                                if (item==phone[6])
                                {
                                    Console.WriteLine("手机号正确");
                                }
                                else
                                {
                                    Console.WriteLine("输入手机号各式不正确！");
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("输入手机号各式不正确！");
                        }
                    }
                    else
                    {
                        Console.WriteLine("输入手机号各式不正确！");
                    }
                }
            }

        }
    }
}
