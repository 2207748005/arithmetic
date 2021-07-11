using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 类
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes = new Shape[3];
            Triangle triangle = new Triangle 
            {
                m = 2,n=2
            };
            Rectangle rectangle = new Rectangle 
            {
                m=2,n=2
            };
            Circle circle = new Circle 
            {
               n=2
            };
            shapes[0] = triangle;
            shapes[1] = rectangle;
            shapes[2] = circle;
            for (int i = 0; i < shapes.Length; i++)
            {
                Console.WriteLine(shapes[i].calArea());
            }

        }
    }

    abstract class Shape
    {
        abstract public  int calArea();
    }

    //三角形
    class Triangle : Shape
    {
        public int n { get; set; }
        public int m { get; set; }
        public override int calArea()
        {
            return m * n / 2;
        }
    }
    //矩形
    class Rectangle : Shape
    {
        public int n { get; set; }
        public int m { get; set; }
        public override int calArea()
        {
            
            return n* m;
        }
    }
    //圆形
    class Circle : Shape
    {
        public int n { get; set; }
        
        public override int calArea()
        {

            return (int)Math.PI * n * n;
        }
    }
}
