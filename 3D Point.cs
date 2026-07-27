using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Point3D
    {
         public  int X { get; set; }
          public int Y { get; set; }
         public int Z { get; set; }

        public Point3D() : this(0, 0 ,0) { }

        public Point3D(int x, int y): this(x,y ,0) { }
        
        public Point3D(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }


        public static bool  operator ==(Point3D a, Point3D b)

        {
            if (ReferenceEquals(a,null) && ReferenceEquals(b,null)) return true;
            if (ReferenceEquals(a, null) || ReferenceEquals(b, null)) return false;

            return a.X == b.X && a.Y ==b.Y && a.Z == b.Z;
        }

        public static bool operator !=(Point3D a, Point3D b)
        {
            return !(a==b);
        }

        public void Display()
        {
            Console.WriteLine($"( {X} , {Y} , {Z} )");
        }
       public static int CalculateDistance(Point3D p1, Point3D p2)
        {

            return Math.Abs(p1.X - p2.X);
        }
    }
}
