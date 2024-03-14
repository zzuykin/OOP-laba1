using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace laba1
{
    public class MyRational
    {
        public int Numerator {  get; private set; }

        public int Denominator { get; private set; }

        public MyRational(int numerator, int denominator)
        {
            if(denominator == 0)
            {
                throw new ArgumentException("Divide by zero!",nameof(denominator));
            }
            this.Numerator = numerator;
            this.Denominator = denominator;
            this.Shorten();
        }

        private int NOD()
        {
            int nod, m = Abs(Numerator), n = Abs(Denominator);
            while (m != n)
            {
                if (m > n)
                {
                    m = m - n;
                }
                else
                {
                    n = n - m;
                }
            }
            nod = n;
            return nod;
        }

        public void Shorten()
        {
            if ( Numerator != 0 )
            {
                int nod = this.NOD();
                Numerator /= nod;
                Denominator /= nod;
                if(Numerator < 0 && Denominator < 0 )
                {
                    Numerator *= -1;
                    Denominator *= -1;
                }
            }
        }

        public override string ToString()
        {
            if (this.Denominator == 1 || this.Denominator == -1 || this.Numerator == 0)
            {
                return Convert.ToString(this.Numerator / this.Denominator);
            }
            if ((this.Numerator < 0 && this.Denominator > 0) || (this.Numerator > 0 && this.Denominator < 0))
            {
                return "-" + Convert.ToString(Abs(this.Numerator)) + "/" + Convert.ToString(Abs(this.Denominator));
            }
            return Convert.ToString(this.Numerator) + "/" + Convert.ToString(this.Denominator);
        }

        public static MyRational operator +(MyRational item1, MyRational item2)
        {
            int numerator, denominator;
            numerator = item1.Numerator * item2.Denominator + item2.Numerator * item1.Denominator;
            denominator = item1.Denominator * item2.Denominator;
            MyRational result = new(numerator, denominator);
            return result;
        }

        public static MyRational operator -(MyRational item1, MyRational item2)
        {
            int numerator, denominator;
            numerator = item1.Numerator * item2.Denominator - item2.Numerator * item1.Denominator;
            denominator = item1.Denominator * item2.Denominator;
            MyRational result = new(numerator, denominator);
            return result;
        }

        public static MyRational operator *(MyRational item1, MyRational item2)
        {
            int numerator, denominator;
            numerator = item1.Numerator * item2.Numerator;
            denominator = item1.Denominator * item2.Denominator;
            MyRational result = new(numerator, denominator);
            return result;
        }

        public static MyRational operator /(MyRational item1, MyRational item2)
        {
            int numerator, denominator;
            numerator = item1.Numerator * item2.Denominator;
            denominator = item1.Denominator * item2.Numerator;
            MyRational result = new(numerator, denominator);
            return result;
        }
        public static MyRational operator -(MyRational item)
        {
            return new MyRational(-item.Numerator, item.Denominator);
        }

        public double Getvalue()
        {
            return Convert.ToDouble(Numerator) / Convert.ToDouble(Denominator);
        }

        public static bool operator == (MyRational left, MyRational right)
        {
            return left.Getvalue() == right.Getvalue();
        }

        public static bool operator != (MyRational left, MyRational right)
        {
            return left.Getvalue() != right.Getvalue();
        }

        public static bool operator < (MyRational left, MyRational right)
        {
            return left.Getvalue() < right.Getvalue();
        }

        public static bool operator >(MyRational left, MyRational right)
        {
            return left.Getvalue() > right.Getvalue();
        }

        public static bool operator >= (MyRational left, MyRational right)
        {
            return left.Getvalue() >= right.Getvalue();
        }

        public static bool operator <=(MyRational left, MyRational right)
        {
            return left.Getvalue() <= right.Getvalue();
        }

    }
}
