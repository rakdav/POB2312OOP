using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4
{
    internal class Point
    {
        public static int count = 0;
        public Point(double x,double y)
        {
            X = x;
            Y = y;
            count++;
        }
        public double X { get; set; }
        public double Y { get; set; }

        public static double LengthPoints(Point p1,Point p2)
        {
            return Math.Sqrt((p1.X - p2.X) * (p1.X - p2.X) + (p1.Y-p2.Y) * (p1.Y-p2.Y));
        }
    }
}
