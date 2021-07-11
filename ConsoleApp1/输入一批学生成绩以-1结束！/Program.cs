using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 输入一批学生成绩以_1结束_
{
    class Program
    {
        //输入一批学生成绩，以-1 作为结束标记 。统计这批学
        //生中，不及格（score<60）、及格（60<=score<70）、中等（70<=score<80）、
        //良好（80<=score<90）、优秀（90<=score<=100）的人数。
        //要求：使用分支、循环结构语句实现
        static void Main(string[] args)
        {
            double sc = 0;
            int a=0, b=0, c=0,d=0,e=0;
            List<double> student = new List<double>();
            while (true)
            {
                Console.WriteLine("请输入一个学生成绩！");
                sc = double.Parse(Console.ReadLine());
                if (sc == -1)
                {
                    break;
                }
                student.Add(sc);
            }
            foreach (var item in student)
            {
                if (item<60)
                {
                    a++;
                }
                else if (item>=60 && item<70)
                {
                    b++;
                }
                else if (item >= 70 && item < 80)
                {
                    c++;
                }
                else if (item >= 80 && item < 90)
                {
                    d++;
                }
                else if (item >= 90 && item < 100)
                {
                    e++;
                }
                else
                {
                    Console.WriteLine("输入成绩有误");
                }
            }
            Console.WriteLine($"不及格人数：{a}");
            Console.WriteLine($"不及格人数：{b}");
            Console.WriteLine($"中等人数{c}");
            Console.WriteLine($"良好人数{d}");
            Console.WriteLine($"优秀人数{e}");
        }
    }
}
