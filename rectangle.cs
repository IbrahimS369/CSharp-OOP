using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public  class Rectangle : Shape

    {
        public Point2d P1  { get; set; }
        public Point2d P2 { get; set; }

        public  Rectangle (Point2d p1, Point2d p2)
        {
            P1 = p1;
            P2 = p2;
        }

        public override double calcArea()
        {
            double width = Math.Abs(P1.X - P2.X);
            double height = Math.Abs(P1.Y - P2.Y);

            return (int)(width * height);
        }
    }
}
