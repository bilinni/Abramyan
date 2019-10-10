using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proc
{
    public class Class1
    {



        public static int Sign(int x)
        {
            if (x < 0)
            {
                return -1;
            }
            else if (x > 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }


        public static int RootsCount(int a, int b, int c)
        {
            if (b * b - 4 * a * c > 0) 
            {
                return 2;
            }
            else if (b * b - 4 * a * c < 0)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }

        public static double CircleS(double r)
        {
            double s = Math.PI * r*r;
            return s;
        }

        public static double RingS(double r1, double r2)
        {
            double s = Math.PI * (r1 * r2);
            return s;
        }

        public static double TriangleP(int a, int h)
        {
            double b = (a / 2) * (a / 2) + h * h;
            return Math.Sqrt(b);
        }

        public static int SumRange(int a, int b)
        {
            if (a > b)
            {
                return 0;
            }
            int range = b - a;
            for (int i = 0; i < range; i++)
                a += 1;
            return a;
        }

        public static int Calc(int a, int b, int proc)
        {
            switch (proc)
            {
                case 1:
                    return a - b;
                    break;

                case 2:
                    return a * b;
                    break;

                case 3:
                    return a / b;
                    break;
                default:
                    return a + b;
                        break;
            }
        }

        public static int Quarter(int x, int y)
        {
            if (x < 0 && y > 0)
            {
                return 1;
            }
            else if (x > 0 && y > 0)
            {
                return 2;
            }

            else if (x > 0 && y > 0)
            {
                return 2;
            }
            else if (x > 0 && y < 0)
            {
                return 4;
            }
            else
            {
                return 3;
            }
        }

        public static bool Even(int k)
        {
            if (k%2==0)
            {
                return true;
            }
            else
            {
                return false;
            }
           
        }

        public static bool IsSquare(double a)
        {
            double res1 = Math.Round(Math.Sqrt(a * a));
            double res2 = a * a;
            if (res1 == res2)
            {
                return true;
            }
            else
            {
                return false;
            }
           
        }

        public static bool IsPower5(int k)
        {
            int res=1;
            while (k>res)
            {
                res *= 5;
            }
            if(res==k)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool IsPower5(int k, int n)
        {
            int res = 1;
            while (k > res)
            {
                res *= n;
            }
            if (res == k)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static int DigitCount(int n)
        {
            int count=0;
            while (n>=10)
            {
                n /= 10;
                count += 1;
            }
            return count;
        }

        public static int DigitN(int n)
        {
            int count = 0;
            while (n >= 10)
            {
                n /= 10;
                count += 1;
            }
            return count;
        }
    }
}
