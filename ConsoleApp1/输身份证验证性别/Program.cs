using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 输身份证验证性别
{
    class Program
    {
        // 验证 18 位身份证号码并判断身份证主人的性别，身份
        //证号码的规则为：
        //①前 17 位全部由数字组成，最后一位为数字或者字符’X’，一个
        //字符 ch 为数字的条件为：ch>=’0’ && ch<=’9’；
        //②第 17 位数为奇数表示性别为男，偶数表示性别为女。
        //输入：从键盘输入一个 18 位的身份证号码保存到字符数组 Card
        //中。
        //输出：主人性别
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("请输入一个18位身份证号");
                string idcard = Console.ReadLine();
                //转换成字符
                char[] Card = idcard.ToCharArray();
                if (Card.Length==18)
                {
                    Console.WriteLine("输入数字有误！");
                }
                else
                {
                    int sex = Convert.ToInt32(Card[16].ToString());
                    if (sex % 2 == 0)
                    {
                        Console.WriteLine("性别是女");
                    }
                    else
                    {
                        Console.WriteLine("性别是男");
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
