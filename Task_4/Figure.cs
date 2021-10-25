using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class Figure
    {
        Point[] point;
        string Type { get; set; }
        public Figure(Point p1, Point p2, Point p3)
        {
            point = new Point[3];
            point[0] = p1;
            point[1] = p2;
            point[2] = p3;
            Type = "треугольник";
        }

        public Figure(Point p1, Point p2, Point p3, Point p4)
        {
            point = new Point[4];
            point[0] = p1;
            point[1] = p2;
            point[2] = p3;
            point[3] = p4;
            Type = "четырехугольник";
        }

        public Figure(Point p1, Point p2, Point p3, Point p4, Point p5)
        {
            point = new Point[5];
            point[0] = p1;
            point[1] = p2;
            point[2] = p3;
            point[3] = p4;
            point[4] = p5;
            Type = "пятиугольник";
        }

        //длинна стороны
        public double LengthSide(Point A, Point B)
        {
            return Math.Sqrt(Math.Pow((B.Y - A.Y), 2) + Math.Pow((B.X - A.X), 2));
        }

        //периметр многоуголника
        public void PerimeterCalculator()
        {
            double total = 0;

            for (int i = 0; i < point.Length - 1; i++)
            {
                total += LengthSide(point[i], point[i + 1]);
            }

            total += LengthSide(point[point.Length - 1], point[0]);
            
            Console.WriteLine("Перимерт фигуры {0} равен {1}",  Type, total);
        }
    }
}
