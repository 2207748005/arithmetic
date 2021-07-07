using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 拼接数组
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array1 = { "a1", "a2", "a3", "a4", "a5" };
            string[] array2 = { "b1", "b2", "b3", "b4", "b5" };
            string[] array3 = new string[array1.Length];
            for (int i = 0; i < array1.Length; i++)
            {
                array3[i] = array1[i] + array2[i];
                Console.Write(array3[i]+",");
            }
        }
    }
}
