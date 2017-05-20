using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace Library264
{
    public class ComplexNumber264
    {
        double A { get; set; }
        double B { get; set; }//todo:是不是得付个初值为0

        double LengthSquare { get { return A * A + B * B; } }
        

        public ComplexNumber264(double a, double b)
        {
            this.A = a;
            this.B = b;
        }


        public static bool operator !=(ComplexNumber264 c1, ComplexNumber264 c2)
        {
            return !(c1 == c2);
        }
        public static bool operator ==(ComplexNumber264 c1, ComplexNumber264 c2)
        {

            return c1.A == c2.B && c1.B == c2.B;
        }
        public static ComplexNumber264 operator -(ComplexNumber264 c1, ComplexNumber264 c2)
        {
            return new ComplexNumber264(c1.A - c2.A, c1.B - c2.B);
        }
        public static ComplexNumber264 operator +(ComplexNumber264 c1, ComplexNumber264 c2)
        {
            return new ComplexNumber264(c1.A + c2.A, c1.B + c2.B);
        }
        public static bool operator <(ComplexNumber264 c1, ComplexNumber264 c2)
        {
            return c1.LengthSquare < c2.LengthSquare;
        }
        public static bool operator <=(ComplexNumber264 c1, ComplexNumber264 c2)
        {
            return c1.LengthSquare <= c2.LengthSquare;
        }
        public static bool operator >(ComplexNumber264 c1, ComplexNumber264 c2)
        {
            return c1.LengthSquare > c2.LengthSquare;
        }
        public static bool operator >=(ComplexNumber264 c1, ComplexNumber264 c2)
        {
            return c1.LengthSquare >= c2.LengthSquare;
        }

        public static ComplexNumber264 Parse(string s)
        {
            Regex re = new Regex(@"([\+\-]?\d+\.?\d*)([\+\-]\d+\.?\d*)i");
            var match = re.Match(s);
            if (match.Length > 0)
            {
                return new ComplexNumber264(
                    double.Parse(match.Groups[1].Value),
                    double.Parse(match.Groups[2].Value));
            }

            re = new Regex(@"([\+\-]?\d+\.?\d*)i");
            match = re.Match(s);

            if (match.Length > 0)
            {
                return new ComplexNumber264(
                    0,
                    double.Parse(match.Groups[1].Value));
            }

            throw new FormatException();
        }
        public override string ToString()
        {
            return String.Format("{0}+{1}i", this.A, this.B);
        }
        bool TryParse(string s,out ComplexNumber264 c)
        {
            try
            {
                c = ComplexNumber264.Parse(s);
                return true;
            }
            catch {
                c = null;
                return false;
            }
        }
        
    }
}
