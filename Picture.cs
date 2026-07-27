    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Picture
    {
       public List<Shape>Shapes {  get; set; }

        public Picture()
        {
            Shapes = new List<Shape>();
        }

        public void addShape(Shape shape)
        {
            Shapes.Add(shape);
        }
        public void DisplayAllShapes()
        {
            foreach (Shape s in Shapes)
            {
                Console.WriteLine($"{s.GetType().Name} Area : {s.calcArea()}");
            }
        }
    }
}
