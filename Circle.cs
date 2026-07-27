namespace ConsoleApp1
{
    public class Circle : Shape
    {
        public double R { get; set; }   
        public Point2d P { get; set; }

        public Circle(Point2d p ,double r) { R = r; P = p; }

        public override double calcArea()
        {
            return Math.PI*R*R;
        }
    }
}
