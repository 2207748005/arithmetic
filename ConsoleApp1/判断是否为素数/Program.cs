using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 判断是否为素数
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            if (sushu(num))
            {
                Console.WriteLine(num+"为素数");
            }
            else
            {
                Console.WriteLine(num+"不能为素数");
            }
            
        }
        static bool sushu(int num)
        {
            for (int i = 2; i <= num / 2; i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
