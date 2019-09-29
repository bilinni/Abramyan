using System;

namespace If
{
    class Program
    {
        static void Main(string[] args)
        {
            If1();
            If2();
            If3();
            If4();
            If5();
            If6();
            If7();
            If8();
            If9();
            If10();
            If11();
            If12();
            If13();
            If14();
            If15();
            If16();
            If17();
            If18();
            If19();
            If20();
            If21();
            If22();
            If23();
            If24();
            If25();
            If26();
            If27();
            If28();
            If29();
            If30();
        }
        
        static void If1()
        {
            int a = 13;
            int r = (a>0? a+=1: a);
            Console.WriteLine(r);
        }
        
        static void If2()
        {
            int a = 13;
            int k = 7;
            int r = (a > 0 ? a += k : a-2);
            Console.WriteLine(r);
        }
        static void If3()
        {
            int a = 13;
            int k = 4;
            if (a > 0)
            {
              a += k;
            }
            else if (a == 0)
            {
              a = 10;
            }
            else
            {
              a -= 2;
            }
            Console.WriteLine(a);
        }
        static void If4()
        {
            int a = 13;
            int b = 21;
            int c = 34;
            int count = 0;
            int r = (a > 0 && b > 0 && c > 0 ? count += 3 : a > 0 && b > 0 ^ b > 0 && c > 0 ^ c > 0 && a > 0 ? a += 2 : a > 0 ^ b > 0 ^ c > 0 ? count += 1 : count = 0);
            Console.WriteLine(r);
        }
        static void If5()
        {
            int a = 13;
            int b = 21;
            int c = 34;
            int count1 = 0;
            int count2 = 0;
            int r1 = (a > 0 && b > 0 && c > 0 ? count1 += 3 : a > 0 && b > 0 ^ b > 0 && c > 0 ^ c > 0 && a > 0 ? a += 2 : a > 0 ^ b > 0 ^ c > 0 ? count1 += 1 : count1 = 0);
            int r2 = (a < 0 && b < 0 && c < 0 ? count2 += 3 : a < 0 && b < 0 ^ b < 0 && c < 0 ^ c < 0 && a < 0 ? a += 2 : a < 0 ^ b < 0 ^ c < 0 ? count2 += 1 : count2 = 0);
            Console.WriteLine(r1 + " " + r2);
        }
        static void If6()
        {
            int a = 13;
            int b = 21;
            int c = 0;
            int r = (a > b ? c = a : c = b);
            Console.WriteLine(c);
        }
        static void If7()
        {
            int a = 13;
            int b = 21;
            int c = 0;
            int r = (a > b ? c = 1 : c = 2);
            Console.WriteLine(c);
        }
        static void If8()
        {
            int a = 13;
            int b = 21;
            int r1 = 0;
            int r2 = 0;
            if(a>b)
            {
                r1 = a;
                r2 = b;
            }
            else
            {
                r1 = b;
                r2 = a;
            }
            Console.WriteLine(r1 + " " + r2);
        }
        static void If9()
        {
            int a = 21;
            int b = 13;
            int r1 = 0;
            int r2 = 0;
            if (a > b)
            {
                r1 = b;
                r2 = a;
            }
            else
            {
                r1 = a;
                r2 = b;
            }
            Console.WriteLine(r1 + " " + r2);
        }
        static void If10()
        {
            int a = 21;
            int b = 13;
            int r1 = 0;
            int r2 = 0;
            if(a==b)
            {
                r1 = b+a;
                r2 = a+b;
            }
            else
            {
                r1 = 0;
                r2 = 0;
            }
            Console.WriteLine(r1 + " " + r2);
        }

        static void If11()
        {
            int a = 21;
            int b = 13;
            int r1 = 0;
            int r2 = 0;
            if (a == b)
            {
                r1 = 0;
                r2 = 0;
            }
            else
            {
                if(a>b)
                {
                    r1 = a;
                    r2 = a;
                }
                else
                {
                    r1 = b;
                    r2 = b;
                }
               
            }
            Console.WriteLine(r1 + " " + r2);
        }
        static void If12()
        {
            int a = 13;
            int b = 21;
            int c = 34;
            int r = 0;
            int res = (a > b && a > c ? r = a : b > a && b > c ? r = b : c > a && c > b ? r = c : r = 0);
            Console.WriteLine(r);
        }
        static void If13()
        {
            int a = 13;
            int b = 21;
            int c = 34;
            int r = 0;
            if(a>b && b>c)
            {
                r = b;
            }
            else if (b>a && a>c)
            {
                r = a;
            }
            else
            {
                r = c;
            }
            Console.WriteLine(r);
        }
        static void If14()
        {
            int a = 13;
            int b = 21;
            int c = 34;
            int r1 = 0;
            int r2 = 0;
            int r3 = 0;
            if (a > b && a > c)
            {
                r1 = a;
                if (b>c)
                {
                    r2 = b;
                    r3 = c;
                }
                else
                {
                    r2 = c;
                    r3 = b;
                }
            }
            else if (b > a && b > c)
            {
                r1 = b;
                if (a > c)
                {
                    r2 = a;
                    r3 = c;
                }
                else
                {
                    r2 = c;
                    r3 = a;
                }
            }
            else
            {
                r1 = c;
                if (a > b)
                {
                    r2 = a;
                    r3 = b;
                }
                else
                {
                    r2 = b;
                    r3 = a;
                }
            }
            Console.WriteLine(r1 + " " + r2 + " " + r3);
        }
        static void If15()
        {
            int a = 13;
            int b = 21;
            int c = 34;
            int r1 = 0;
            int r2 = 0;
            if (a > b && a > c)
            {
                r1 = a;
                if (b > c)
                {
                    r2 = b;
                }
                else
                {
                    r2 = c;
                }
            }
            else if (b > a && b > c)
            {
                r1 = b;
                if (a > c)
                {
                    r2 = a;
                }
                else
                {
                    r2 = c;
                }
            }
            else
            {
                r1 = c;
                if (a > b)
                {
                    r2 = a;
                }
                else
                {
                    r2 = b;                   
                }
            }
            Console.WriteLine(r1 + " " + r2);
        }
        static void If16()
        {
            int a = 41;
            int b = 21;
            int c = 7;
           // int r = (a > b ? a *= 2 : b > c ? b *= 2 : c < a ? c *= 2 : a = -a, b = -b, c = -c);
            if (a>b && b>c && c<a)
            {
                a *= 2;
                b *= 2;
                c *= 2;
            }
            else
            {
                a = -a;
                b = -b;
                c = -c;
            }
            Console.WriteLine(a + " " + b + " " + c);
        }
        
        static void If17()
        {
            int a = 41;
            int b = 21;
            int c = 7;
            if (a > b && b > c && c < a ^ a < b && b < c && c > a)
            {
                a *= 2;
                b *= 2;
                c *= 2;
            }
            else
            {
                a = -a;
                b = -b;
                c = -c;
            }
            Console.WriteLine(a + " " + b + " " + c);
        }
        static void If18()
        {
            int a = 13;
            int b = 13;
            int c = 34;
            int r = 0;
            int res = (a == b ? r = 3 : a == c ? r = 2 : c == b ? r = 1 : r = 0);
            Console.WriteLine(r);
        }
        static void If19()
        {
            int a = 13;
            int b = 13;
            int c = 13;
            int d = 24;
            int r = 0;
            int res = (a == b && b == c? r=4 : b == c && c == d ? r = 1 : a == d && d == c ? r = 2 : r = 3);
            Console.WriteLine(r);
        }
        static void If20()
        {
            int a = 13;
            int b = 21;
            int c = 34;
            int r = 0;
            int res = (Math.Abs(a - b) < Math.Abs(a - c) ? r = b : r = c);
            Console.WriteLine(r);
        }
        static void If21()
        {
            int x = 13;
            int y = 21;
            int r = 0;
            int res = (x==0 && y==0? r=0 : x==0 && y!=0? r=1 : x!=0 && y==0? r=2 : r=3);
            Console.WriteLine(r);
        }
        static void If22()
        {
            int x = 13;
            int y = 21;
            int r = 0;
            int res = (x < 0 && y > 0 ? r = 1 : x > 0 && y > 0 ? r = 2 : x < 0 && y < 0 ? r = 3 : r = 4);
            Console.WriteLine(r);
        }
        static void If23()
        {
            int x1 = 0;
            int y1 = 0;
            int x2 = 0;
            int y2 = 5;
            int x3 = 10;
            int y3 = 5;
            int x4 = x3;
            int y4 = y1;
            Console.WriteLine(x4 + " " + y4);
        }
        static void If24()
        {
            int x = -7;
            double fx = 0;
            double r = (x > 0 ? fx = 2 * Math.Sin(x) : fx = 6 - x);

            Console.WriteLine(fx);
        }
        static void If25()
        {
            int x = -7;
            int fx = 0;
            int r = (x < -2 || x > 2 ? fx = 2 * x : fx = -3 * x);

            Console.WriteLine(fx);
        }
        static void If26()
        {
            int x = -7;
            int fx = 0;
            int r = (x <= 0 ? fx = -x : x>=0 && x<2? fx=x*x : fx=4);

            Console.WriteLine(fx);
        }
        static void If27()
        {
            int x = -7;
            int fx = 0;
            int r = (x < 0 ? fx = 1 : x % 2 == 0 || x == 0 ? fx = 1 : fx = -1);
            
            Console.WriteLine(fx);
        }
        static void If28()
        {
            int a = 1312;
            int r = 0;
            int r1 = 365;
            int r2 = 366;
            int res = (a % 4 == 0 || a % 100 != 0 && a % 400 == 0 ? r = r2 : r = r1);
            Console.WriteLine(r);
        }
        static void If29()
        {
            int a = 513;
            string r = " ";
            string r1 = "нулевое число";
            string r2 = "положительное четное число";
            string r3 = "положительное нечетное число";
            string r4 = "отрицательное четное число";
            string r5 = "отрицательное нечетное число";

            if (a > 0)
            {
                if (a % 2 ==0)
                {
                    r = r2;
                }
              
                else
                {
                    r = r3;
                }
            }
            else if (a < 0)
            {
                if (a % 2 == 0)
                {
                    r = r4;
                }
                else 
                {
                    r = r5;
                }          
            }
            else
            {
                r = r1;
            }
            Console.WriteLine(r);
        }

        static void If30()
        {
            int a = 513;
            string r = " ";
            string r1 = "нечетное число";
            string r2 = "четное число";
            string r3 = "нечетное двузначное число";
            string r4 = "четное двузначное число";
            string r5 = "нечетное трехзначное число";
            string r6 = "четное трехзначное число";

            if (a % 2 != 0)
            {
                if(a/100>=1)
                {
                    r = r5;
                }
                else if(a/10>=1)
                {
                    r = r3;
                }
                else
                {
                    r = r1;
                }
            }
            else if (a % 2 == 0)
            {
                if (a / 100 >= 1)
                {
                    r = r6;
                }
                else if (a / 10 >= 1)
                {
                    r = r4;
                }
                else
                {
                    r = r2;
                }
            }
            else
            {
                Console.WriteLine("Error");
            }
            Console.WriteLine(r);
        }
    }
}
