using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 二维数组的使用
{
	class Program
	{
		static void Main(string[] args)
		{
			int[,] a = new int[30,5];//存放30个学生的成绩
			int[] b = new int[5];//存放30个学生的平均成绩
								  //输入每个学生的5门成绩
			for (int i = 0; i < a.Length; i++)
			{
				Console.WriteLine("第" + (i + 1) + "个学生的5门成绩:\t");
				int count = 0; //局部变量，学生的成绩
				for (int j = 0; j < b.Length; j++)
				{
                    do
                    {
                        a[i,j] = new Random().Next(101);//随机生成一个学生一门成绩分数
                    } while (a[i,j] < 60);//如果低于60分则重新生成
                                           //a[i][j] =
                    count += a[i,j]; //学生5门成绩的总分
					Console.WriteLine(a[i,j] + "\t");
				}
				count = count / 5; //学生5门成绩的平均分
				b[i] = count; //存放到b数组中
				Console.WriteLine("");
				Console.WriteLine("第" + (i + 1) + "个学生的5门成绩的平均分为:\t" + b[i]);
				Console.WriteLine("");
			}
			//
			for (int i = 0; i < b.Length; i++)
			{
				Console.WriteLine("第" + (i + 1) + "个学生的5门成绩的平均分为:\t" + b[i]);

			}
		}
	}
}
