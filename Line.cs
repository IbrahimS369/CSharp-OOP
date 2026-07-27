using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Line 
    {
        public Point2d P1 { get; set; }
        public Point2d P2 { get; set; }

        public Line(Point2d p1 , Point2d p2) 
        {
            P1 = p1;
            P2 = p2;
        
        }

        public  int getLength()
        {
            double D = Math.Sqrt(Math.Pow(P2.X - P1.X, 2) + Math.Pow(P2.Y - P1.Y, 2));
            return (int)D ;
        }
    }
}
