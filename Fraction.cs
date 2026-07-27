using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Fraction
    {
        public int Numerator {  get; set; } 
        public int Denominator { get; set; }




        public Fraction() : this(0,1) { }
        public Fraction(int numerator, int denominator)
        {
            Numerator = numerator;
            Denominator = denominator !=0 ? denominator : 1;
        }
  
        public static Fraction operator +(Fraction F1 , Fraction F2)
        {
            int num = (F1.Numerator * F2.Denominator) + (F1.Denominator * F2.Numerator);
            int dem = F1.Denominator * F2.Denominator;
            return new Fraction(num, dem);  

        }

        public static implicit operator Fraction(int n)
        {
            return new Fraction(n, 1);
        }

        public static explicit operator double(Fraction f)
        {
            return (double)f.Numerator / f.Denominator;
        }
   
        public void Dispay()
        {
            Console.WriteLine($"{Numerator} /{Denominator}");
        }

        public static  Fraction Add(Fraction f1 ,  Fraction f2)
        {
            Fraction result = new Fraction();
            result.Numerator = (f1.Numerator * f2.Denominator) + (f2.Numerator * f1.Denominator);
            result.Denominator = f1.Denominator * f2.Denominator;

            return result;
        }

        public Fraction Add(Fraction f)
        {
            Fraction result =Fraction.Add(this, f );

            //result.Numerator = ( this.Numerator * f.Denominator) + (f.Numerator* this.Denominator);  
            //result.Denominator = (this.Denominator*f.Denominator);


            return result;
        }
    }
}
