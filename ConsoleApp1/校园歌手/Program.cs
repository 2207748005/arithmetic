using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 校园歌手
{
    class Program
    {
        //小明今天参加了“校园歌手大赛”，评委的打分规则是
        //去掉一个最低分和一个最高分后算出剩下分数的平均分，你能帮助小
        //明快速的算出平均分吗？（评委数量必须大于 2）
        //输入说明：首先输入一个整数 n，代表评委人数，然后输入 n 个
        //数。请按照题目的计算规则计算出平均分然后输出。42
        //例如输入：
        //6
        //100 90 90 80 85 95
        //按照题目要求计算平均分并输出：
        //90.0
        //要求：使用循环和数组实现。
        static void Main(string[] args)
        {
            Console.WriteLine("请输入评为数：");
            int num = int.Parse(Console.ReadLine());
            if (num<2)
            {
                Console.WriteLine("输入的评委数量太少了");
            }
            else
            {
                //定义一个数组用来保存评为输入的成绩
                int[] grade = new int[num];
                
                for (int i = 0; i < num; i++)
                {
                    grade[i] = int.Parse(Console.ReadLine());
                }
                //装换成一个集合
                List<int> list = grade.ToList();
                //对集合进行排序
                var sc = list.OrderBy(a => a).ToList();
                //去掉最高分和最低分
                list.Remove(sc[0]);
                list.Remove(sc[sc.Count - 1]);
                //输出平均值
                Console.WriteLine(sc.Average().ToString("F1"));

            }
           

        }
    }
}
