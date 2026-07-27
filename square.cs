using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Square : Rectangle
    {
      
        public Square(Point2d startP, int sideLength):
            base (startP , new Point2d(startP.X+sideLength , startP.Y + sideLength))
        {  }

     

    }
}
    