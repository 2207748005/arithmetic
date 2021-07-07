using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 取奇数
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            int[] newarr = OddArray(arr);
            foreach (int i in newarr)
            {
                Console.WriteLine(i);
            }
            Console.Read();
        }
        public static int[] OddArray(int[] arr)
        {
            List<int> li = new List<int>();
            foreach (int i in arr)
            {
                if (i % 2 != 0)
                {
                    li.Add(i);
                }
            }
            return li.ToArray();
        }
    }
}
