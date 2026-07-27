namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Point3D p1 = new Point3D(3, 6, 9);
            //Point3D p2 = new Point3D(4, 5, 6);

            //p1.Display();
            //p2.Display();

            //Point3D p3 = new Point3D();
            //Point3D p4 = new Point3D(5, 10);
            //p3.Display();
            //p4.Display();

            //int distance = Point3D.CalculateDistance(p1, p2);
            //Console.WriteLine($" disstance between p1 and p2 (X only ) is : {distance}");


            //Console.WriteLine("******************************************");

            //Fraction f1 = new Fraction(3, 9);
            //Fraction f2 = new Fraction(4, 9);

            //Console.Write("Fraction 1: ");
            //f1.Dispay();

            //Console.Write("Fraction 2: ");
            //f2.Dispay();

            //Fraction sun = Fraction.Add(f1, f2);
            //Console.WriteLine($"result of sum is :");
            //sun.Dispay();

            //Fraction sum = f1.Add(f2);
            //sum.Dispay();

            //Point2d P1 = new Point2d(8, 8);
            //Point2d P2 = new Point2d(6, 5);

            //Line myLine = new Line(P1, P2);
            //Console.WriteLine($"Line Length is : {myLine.getLength()}");

            //Point2d recP1 = new Point2d(1, 3);
            //Point2d recP2 = new Point2d(5, 6);

            //Rectangle myR = new Rectangle(recP1, recP2);
            //Console.WriteLine($"rec area is : {myR.calcArea()}");


            //Point2d sqPoint = new Point2d(0, 0);
            //Square mySquare = new Square(sqPoint, 5);
            //Console.WriteLine($"sq area is : {mySquare.calcArea()}");

            //Point2d Cp = new Point2d(5, 7);
            //Circle C = new Circle(Cp, 7);
            //Console.WriteLine($"Circle area is : {C.calcArea()}");


            //Picture myPic = new Picture();
            //myPic.Shapes.Add(new Rectangle(new Point2d(0, 5), new Point2d(0, 9)));

            //myPic.Shapes.Add(new Square(new Point2d(9, 7), 5));

            //myPic.Shapes.Add(new Circle(new Point2d(5, 9), 9));


            //myPic.DisplayAllShapes();


            Point3D p1 = new Point3D(3, 69, 7);
            Point3D p2 = new Point3D(78, 9, 7);
            Point3D p3 = new Point3D(3, 69, 7);

            Console.WriteLine($" p1 == p3 ? : {p1==p3} ");
            Console.WriteLine($" p1 == p2 ? : {p1 == p2}");

            Fraction f1 = new Fraction(1,2);
            Fraction f2 = new Fraction(6,2);

            Fraction f3 = f1 + f2;
            Console.Write("f1 + f2 = ");
            f3.Dispay();

            Fraction f4 = 87;
            Console.Write("Implicit conversion to Fraction: ");
            f4.Dispay();

            double f5 = (double)f1;
            Console.WriteLine(f5);
        }
    }
}
