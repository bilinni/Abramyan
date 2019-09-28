using System;

namespace Bool
{
    class Program
    {
        static void Main(string[] args)
        {
            Bool1();
            Bool2();
            Bool3();
            Bool4();
            Bool5();
            Bool6();
            Bool7();
            Bool8();
            Bool9();
            Bool10();
            Bool11();
            Bool12();
            Bool13();
            Bool14();
            Bool15();
            Bool16();
            Bool17();
            Bool18();
            Bool19();
            Bool20();
            Bool21();
            Bool22();
            Bool23();
            Bool24();
            Bool25();
            Bool26();
            Bool27();
            Bool28();
            Bool29();
            Bool30();
            Bool31();
            Bool32();
            Bool33();
            Bool34();
            Bool35();
            Bool36();
            Bool37();
            Bool38();
            Bool39();
            Bool40();
        }
        static void Bool1()
        {
            int a = 10;
            bool b = a > 0;
            Console.WriteLine(b);
        }

        static void Bool2()
        {
            int a = 32;
            bool b = a % 2 != 0;
            Console.WriteLine(b);
        }

        static void Bool3()
        {
            int a = 32;
            bool b = a % 2 == 0;
            Console.WriteLine(b);
        }

        static void Bool4()
        {
            int a = 7;
            int b = -3;
            bool c = a > 2 && b <= 3;
            Console.WriteLine(c);
        }

        static void Bool5()
        {
            int a = 8;
            int b = 2;
            bool c = a >= 0 && b < -2;
            Console.WriteLine(c);
        }

        static void Bool6()
        {
            int a = 32;
            int b = 17;
            int c = 50;
            bool d = a < b || b < c;
            Console.WriteLine(d);
        }

        static void Bool7()
        {
            int a = 32;
            int b = 17;
            int c = 50;
            bool d = (a < b && b < c) || (a > b && b > c);
            Console.WriteLine(d);
        }

        static void Bool8()
        {
            int a = 32;
            int b = 17;
            bool c = a % 2 != 0 && b % 2 != 0;
            Console.WriteLine(c);
        }

        static void Bool9()
        {
            int a = 32;
            int b = 17;
            bool c = a % 2 != 0 || b % 2 != 0;
            Console.WriteLine(c);
        }

        static void Bool10()
        {
            int a = 32;
            int b = 17;
            bool c = a % 2 != 0 ^ b % 2 != 0;
            Console.WriteLine(c);
        }

        static void Bool11()
        {
            int a = 32;
            int b = 17;
            bool c = a % 2 == 0;
            bool d = b % 2 == 0;
            bool xr = c == d;
            Console.WriteLine(xr);
        }

        static void Bool12()
        {
            int a = 32;
            int b = 17;
            int c = 7;
            bool d = a > 0 && b > 0 && c > 0;
            Console.WriteLine(d);
        }

        static void Bool13()
        {
            int a = 32;
            int b = 17;
            int c = 7;
            bool d = a > 0 || b > 0 || c > 0;
            Console.WriteLine(d);
        }

        static void Bool14()
        {
            int a = 32;
            int b = 17;
            int c = 7;
            bool d = a > 0 ^ b > 0 ^ c > 0;
            Console.WriteLine(d);
        }

        static void Bool15()
        {
            int a = 32;
            int b = 17;
            int c = 7;
            bool d = a > 0 ^ b > 0 || b > 0 ^ c > 0 || c > 0 ^ a > 0;
            Console.WriteLine(d);
        }

        static void Bool16()
        {
            int a = 32;
            bool b = a % 2 == 0 && a / 10 > 0;
            Console.WriteLine(b);
        }

        static void Bool17()
        {
            int a = 32;
            bool b = a % 2 != 0 && a / 100 > 0;
            Console.WriteLine(b);
        }

        static void Bool18()
        {
            int a = 32;
            int b = 24;
            int c = 13;
            bool d = a == b || b == c || c == a;
            Console.WriteLine(d);
        }

        static void Bool19()
        {
            int a = 32;
            int b = 24;
            int c = 13;
            bool d = a == b || b == c || c == a;
            Console.WriteLine(d);
        }

        static void Bool20()
        {
            int a = 325;
            int a1 = a / 100;
            int a2 = a / 10 - a1 * 10;
            int a3 = a - (a1 * 100 + a2 * 10);
            bool b = a1 != a2 || a2 != a3 || a3 != a1;
            Console.WriteLine(b);
        }

        static void Bool21()
        {
            int a = 325;
            int a1 = a / 100;
            int a2 = a / 10 - a1 * 10;
            int a3 = a - (a1 * 100 + a2 * 10);
            bool b = a1 < a2 || a2 < a3 || a3 > a1;
            Console.WriteLine(b);
        }

        static void Bool22()
        {
            int a = 325;
            int a1 = a / 100;
            int a2 = a / 10 - a1 * 10;
            int a3 = a - (a1 * 100 + a2 * 10);
            bool b = a1 < a2 || a2 < a3 || a3 > a1 ^ a1 > a2 || a2 > a3 || a3 < a1;
            Console.WriteLine(b);
        }

        static void Bool23()
        {
            int a = 6247;
            int a1 = a / 1000;
            int a2 = (a - a1 * 1000) / 100;
            int a3 = (a - (a1 * 1000 + a2 * 100)) / 10;
            int a4 = (a - (a1 * 1000 + a2 * 100 + a3 * 10));
            bool b = a1 == a4 && a2 == a3;
            Console.WriteLine(b);
        }

        static void Bool24()
        {
            int a = 3;
            int b = 7;
            int c = 21;
            int d = b * b - 4 * a * c;
            bool xr = d >= 0;
            Console.WriteLine(xr);
        }

        static void Bool25()
        {
            int x = 32;
            int y = 13;
            bool a = x>0 && y>0;
            Console.WriteLine(a);
        }

        static void Bool26()
        {
            int x = 32;
            int y = 13;
            bool a = x > 0 && y < 0;
            Console.WriteLine(a);
        }

        static void Bool27()
        {
            int x = 32;
            int y = 13;
            bool a = x > 0 && y > 0 || x < 0 && y < 0;
            Console.WriteLine(a);
        }

        static void Bool28()
        {
            int x = 32;
            int y = 13;
            bool a = x < 0 && y > 0 || x < 0 && y < 0;
            Console.WriteLine(a);
        }

        static void Bool29()
        {
            int x = 3;
            int y = 4;
            int x1 = 7;
            int y1 = 4;
            int x2 = 8;
            int y2 = 3;
            bool a = x < x1 && y < y1 && x > x2 && y > y2;
            Console.WriteLine(a);
        }

        static void Bool30()
        {
            int a = 7;
            int b = 6;
            int c = 3;
            bool d = a == b && b == c && c == a; 
            Console.WriteLine(d);
        }

        static void Bool31()
        {
            int a = 7;
            int b = 5;
            int c = 3;
            bool d = a == b || b == c || c == a;
            Console.WriteLine(d);
        }

        static void Bool32()
        {
            int a = 9;
            int b = 6;
            int c = 3;
            bool d = a * a = b * b + c * c;
            Console.WriteLine(d);
        }

        static void Bool33()
        {
            int a = 9;
            int b = 6;
            int c = 3;
            bool d = a + b < c || b + c < a || c + a < b;
            Console.WriteLine(d);
        }

        static void Bool34()
        {
            int x = 4;
            int y = 5;
            bool xr = x % 2 != y % 2;
            Console.WriteLine(xr);
        }

        static void Bool35()
        {
            int x1 = 4;
            int y1 = 5;
            int x2 = 8;
            int y2 = 7;
            bool xr = (x1 + x2 + y1 + y2) % 2 == 0;
            Console.WriteLine(xr);
        }
        static void Bool36()
        {
            int x1 = 4;
            int y1 = 5;
            int x2 = 8;
            int y2 = 7;
            bool xr = x1 == x2 || y1 == y2;
            Console.WriteLine(xr);
        }
        static void Bool37()
        {
            int x1 = 4;
            int y1 = 5;
            int x2 = 8;
            int y2 = 7;
            bool xr = Math.Abs(x1 - x2) == 1 || Math.Abs(y1 - y2) == 1;
            Console.WriteLine(xr);
        }
        static void Bool38()
        {
            int x1 = 4;
            int y1 = 6;
            int x2 = 8;
            int y2 = 2;
            bool xr = x1 + y1 == x2 + y2;
            Console.WriteLine(xr);
        }
        static void Bool39()
        {
            int x1 = 4;
            int y1 = 6;
            int x2 = 8;
            int y2 = 2;
            bool xr = x1 + y1 == x2 + y2 || x1 == x2 || y1 == y2;
            Console.WriteLine(xr);
        }
        static void Bool40()
        {
            int x1 = 4;
            int y1 = 5;
            int x2 = 6;
            int y2 = 7;
            bool xr = (Math.Abs(y1 - y2) == 2 && Math.Abs(x1 - x2) == 1) || (Math.Abs(y1 - y2) == 1 && Math.Abs(x1 - x2) == 2);
            Console.WriteLine(xr);
        }
}
