using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 计算珠穆朗玛峰高度
{
    class Program
    {
        static void Main(string[] args)
        {   
            //纸张的原始高度
            double H = 0.0005;
            int num = 0;//对折次数
            double z = H;//纸张对折的高度
            double f = 8844.43;//珠峰的高度
            while (z<f)
            {
                z *= 2;
                num++;//每叠一层增加一次次数
            }
            Console.WriteLine(num);
        }
    }
}
