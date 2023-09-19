using System.Reflection.Metadata;
using System.Xml.Linq;

namespace Lib
{
    public class Rational
    {
        public static readonly Rational Zero, One;
        long m, n;
        public Rational(long a, long b)
        {
            const string mes = "Знаменатель рационального числа не может быть равен нулю";
            if (b == 0) throw new RationalException(mes);
            else
            {
                if (a == 0)
                {
                    m = 0; n = 1;
                }
                else
                {
                    if (b < 0)
                    {
                        b = -b; a = -a;
                    }
                    long d = nod(a, b);
                    m = a / d; n = b / d;
                }
            }
        }//Конструктор

        private Rational(long a, long b, string t) 
        {
            m = a; n = b;
        }

        static Rational()
        {

        }//Статический конструктор

        long nod(long m, long n)
        {
            long p = 0;
            n = Math.Abs(n);
            m = Math.Abs(m);
            if (n>m)
            {
                p = m; m = n; n = p;
            }
            do
            {
                p = m % n; m = n; n = p;

            } while (n != 0);
            return (m);
        }

        public override string ToString()
        {
            return ( m + "/" + n);
        }

        public string PrintRational(string name)
        {
            return (name + "=" + m.ToString() + "/" + n.ToString());
        }

        public Rational Plus(Rational a)
        {
            long u, v;
            u = m * a.n + n * a.m;v = n * a.n;
            return new Rational(u, v);
        }

        public static Rational operator +(Rational r1, Rational r2)
        {
            return (r1.Plus(r2));
        }

        public Rational Minus(Rational a)
        {
            long u, v;
            u = m * a.n - n * a.m; v = n * a.n;
            return (new Rational(u, v));
        }

        public static Rational operator -(Rational r1, Rational r2)
        {
            return (r1.Minus(r2));
        }

        public Rational Mult(Rational a)
        {
            long u, v;
            u = m * a.m;v = n * a.n;
            return (new Rational(u, v));
        }

        public static Rational operator *(Rational r1, Rational r2)
        {
            return (r1.Mult(r2));
        }

        public Rational Divide(Rational a)
        {
            long u, v;
            u = m * a.n;v = n * a.m;
            return (new Rational(u, v));
        }

        public static Rational operator /(Rational r1, Rational r2)
        {
            return (r1.Divide(r2));
        }

        public static bool operator ==(Rational r1, Rational r2)
        {
            return ((r1.m == r2.m) && (r1.n == r2.n));
        }

        public static bool operator !=(Rational r1, Rational r2)
        {
            return ((r1.m != r2.m) || (r1.n != r2.n));
        }

        public static bool operator <(Rational r1, Rational r2)
        {
            return ((r1.m * r2.n) < (r1.m * r2.n));
        }

        public static bool operator >(Rational r1, Rational r2)
        {
            return ((r1.m * r2.n) > (r1.m * r2.n));
        }

        public static bool operator <(Rational r1, double r2)
        {
            return ((double)r1.m / (double)r1.n < r2);
        }

        public static bool operator >(Rational r1, double r2)
        {
            return ((double)r1.m / (double)r1.n > r2);
        }

        public override bool Equals(object obj)
        {
            return (this == (Rational)obj);
        }

        public override int GetHashCode()
        {
            return (int)(m^n);
        }

        public Rational Pow(long k)
        {
            long u, v;
            u = P(m, k); v = P(n, k);
            return (new Rational(u, v));
        }

        long P(long a, long k)
        {
            long z = 1;
            while (k!=0)
            {
                while(k%2==0)
                {
                    k /= 2; a *= a;
                }

                {
                    z *= a; k--;
                }
            }
            return z;
        }

        public static Rational operator ^(Rational r1, long n)
        {
            return (r1.Pow(n));
        }

        public Rational RationalRound(int k)
        {
            long u = LongRound(m, k);
            long v = LongRound(n, k);
            return (new Rational(u, v));
        }

        long LongRound(long x, int k)
        {
            string s1 = x.ToString();
            if (k >= s1.Length) return x;
            string s2 = s1.Substring(0,k);
            string s3 = s2.Substring(k,1);
            if (int.Parse(s3) >= 5)
                s2 = (int.Parse(s2) + 1).ToString();
            for (int i = 0; i < s1.Length - k; i++)
            {
                s2 += "0";
            }
            return (long.Parse(s2));
        }
        
        class RationalException : Exception
        {
            public RationalException()
            {

            }
            public RationalException(string message) : base(message)
            {

            }
            public RationalException(string message, Exception e) : base(message, e)
            {
                
            }
        }
    }
}