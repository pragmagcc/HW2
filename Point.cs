using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Points2D// рабочее пространство называется как проект
{
    internal class Point// класс называется как файл, в котором он написан
    {
        public int x = 0;
        public int y = 0;
        public Point(int x, int y)// конструктор
        {
            this.x = x;
            this.y = y;
        }
        public static Point vector(Point p1, Point p2)
        {
            return new Point(p2.x - p1.x, p2.y - p1.y);
        }// p1 начало вектора, p2 конец вектора 
        public double length(int x, int y)
        {
            return Math.Sqrt((this.x - x) * (this.x - x) + (this.y - y) * (this.y - y));
        }
        public double length(Point p)
        {
            return Math.Sqrt((this.x - p.x) * (this.x - p.x) + (this.y - p.y) * (this.y - p.y));
        }
        // перегрузка методов (два или более метода с одним названием и разными аргументами)
        public double coordinate()
        {
            return Math.Sqrt(x * x + y * y);
        }
        public double angle(Point p1, Point p2)
        {
            Point V1 = vector(this, p1);
            Point V2 = vector(this, p2);
            double cos = (V1.x * V2.x + V1.y * V2.y) / (this.length(p1) * this.length(p2));
            return cos;
        }
        public int signOfPoint(Point p1, Point p2)
        {
            if ((this.x - p1.x) * (p2.y - p1.y) - (p2.x - p1.x) * (this.y - p1.y) >= 0)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }


    }

}