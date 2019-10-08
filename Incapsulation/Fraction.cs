using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Incapsulation
{
    class Fraction
    {
        int numerator;
        int denominator;

        public int Numerator { get => numerator; set => numerator = value; }
        public int Denominator { get => denominator; set => denominator = (value != 0) ? value : throw new DivideByZeroException(); }

        public Fraction(int numerator, int denominator)
        {
            Numerator = numerator;
            Denominator = denominator;
        }

        public Fraction()
        {

        }

        public void Reverse()
        {
            int temp = numerator;           
            try
            {                
                Denominator = temp;
                Numerator = denominator;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }

        public Fraction Sum(Fraction second)
        {
            Fraction result = new Fraction();
            result.Denominator = denominator * second.denominator;
            result.Numerator = numerator * second.denominator + second.numerator * denominator;

            return result;
        }

        public static Fraction operator +(Fraction first, Fraction second)
        {
            Fraction result = new Fraction();
            result.Denominator = first.denominator * second.denominator;
            result.Numerator = first.numerator * second.denominator + second.numerator * first.denominator;

            return result;
        }

        public Fraction Mult(Fraction second)
        {
            Fraction result = new Fraction(numerator*second.numerator, denominator*second.denominator);
            return result;
        }

        public override string ToString()
        {
            return $"{numerator}/{denominator}";
        }
    }
}
