using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 全网叫协议
{
    class Program
    {
        //IP 全称叫网际协议，有时我们又用 IP 来指代我们的 IP
        //网络地址，现在 IPV4 下用一个 32 位无符号整数来表示，一般用点分
        //方式来显示，点将 IP 地址分成 4 个部分，每个部分为 8 位，表示成
        //一个无符号整数（因此不需要用正号出现），如 192.168.100.16，是我
        //们非常熟悉的 IP 地址，一个 IP 地址串中没有空格出现（因为要表示
        //成一个 32 数字）。但是粗心的我，常常将 IP 地址写错，现在需要你
        //用程序来判断。接收用户输入的字符串，判断其是否是合法的 IP 地
        //址，是的话输出”YES”，否则输出”NO”。
        //例如输入：192.168.1.3 程序需要输出 YES
        static void Main(string[] args)
        {
            Console.WriteLine("请输入一个ip地址");
            string ip = Console.ReadLine();
            string[] str = ip.Split('.');
            if (str.Length!=4)
            {
                Console.WriteLine("输入的ip地址不符合规则！");
                return;
            }
            //遍历str
            foreach (var item in str)
            {
                //如果每个网段都有内容就不会进入此判断
                if (item.Length==0)
                {
                    Console.WriteLine("No");
                    return;
                }
                //网段是否符合区间
                if (Convert.ToInt32(item)<0||Convert.ToInt32(item)>225)
                {
                    Console.WriteLine("No");
                    return;
                }
                foreach (var i in item)
                {
                    try
                    {
                        //不为数字的会异常，这里用异常处理
                        if (item == " " || Convert.ToInt32(item) < 0)
                        {
                            Console.WriteLine("No");
                            return;
                        }
                    }
                    catch 
                    {
                        Console.WriteLine("No");
                        return;
                    }
                }
            }
            Console.WriteLine("yes");
        }
    }
}
