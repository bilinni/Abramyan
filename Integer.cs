using System;

namespace Integer
{
    class Program
    {
        static void Main()
        {
            Integer1();
            Integer2();
            Integer3();
            Integer4();
            Integer5();
            Integer6();
            Integer7();
            Integer8();
            Integer9();
            Integer10();
            Integer11();
            Integer12();
            Integer13();
            Integer14();
            Integer15();
            Integer16();
            Integer17();
            Integer18();
            Integer19();
            Integer20();
            Integer21();
            Integer22();
            Integer23();
            Integer24();
            Integer25();
            Integer26();
            Integer27();
            Integer28();
            Integer29();
            Integer30();
        }
        static void Integer1()
        {
            int L = 153;
            int L1 = L / 100;
            Console.WriteLine(L1);
        }
        static void Integer2()
        {
            int M = 7653;
            int M1 = M / 1000;
            Console.WriteLine(M1);
        }
        static void Integer3()
        {
            int B = 16661;
            int KB = B / 1024;
            Console.WriteLine(KB);
        }
        static void Integer4()
        {
            int A = 22;
            int B = 15;
            int C = A / B;
            Console.WriteLine(C);
        }
        static void Integer5()
        {
            int A = 21;
            int B = 85;
            int C = A % B;
            Console.WriteLine(C);
        }
        static void Integer6()
        {
            int A = 42;
            int X = A / 10;
            int Y = A % 10;
            Console.WriteLine(X + " " + Y);
        }
        static void Integer7()
        {
            int A = 58;
            int X = A / 10;
            int Y = A % 10;
            int B = X * Y;
            int C = X + Y;
            Console.WriteLine(C + " " + B);
        }
        static void Integer8()
        {
            int A = 51;
            int X = A / 10;
            int Y = A % 10;
            int B = Y * 10 + X;
            Console.WriteLine(B);
        }
        static void Integer9()
        {
            int A = 634;
            int B = A / 100;
            Console.WriteLine(B);
        }
        static void Integer10()
        {
            int A = 573;
            int X = A % 10;
            int Y = (A / 10) % 10;
            Console.WriteLine(X + " " + Y);
        }
        static void Integer11()
        {
            int A = 724;
            int X = A % 10;
            int Y = (A / 10) % 10;
            int Z = A / 100;
            int P = Z * X * Y;
            int R = X + Y + Z;
            Console.WriteLine(R + " " + P);
        }
        static void Integer12()
        {
            int A = 724;
            int X = A % 10;
            int Y = (A / 10) % 10;
            int Z = A / 100;
            int B = X * 100 + Y * 10 + Z;
            Console.WriteLine(B);
        }
        static void Integer13()
        {
            int A = 623;
            int X = A % 10;
            int Y = (A / 10) % 10;
            int Z = A / 100;
            int B = Y * 100 + X * 10 + Z;
            Console.WriteLine(B);
        }
        static void Integer14()
        {
            int A = 512;
            int X = A % 10;
            int Y = (A / 10) % 10;
            int Z = A / 100;
            int B = X * 100 + Z * 10 + Y;
            Console.WriteLine(B);
        }
        static void Integer15()
        {
            int A = 512;
            int X = A % 10;
            int Y = (A / 10) % 10;
            int Z = A / 100;
            int B = Y * 100 + Z * 10 + X;
            Console.WriteLine(B);
        }
        static void Integer16()
        {
            int A = 512;
            int X = A % 10;
            int Y = (A / 10) % 10;
            int Z = A / 100;
            int B = Z * 100 + X * 10 + Y;
            Console.WriteLine(B);
        }
        static void Integer17()
        {
            int A = 6723;
            int X = A / 100;
            int B = X % 10;
            Console.WriteLine(B);
        }
        static void Integer18()
        {
            int A = 6361;
            int X = A / 1000;
            int B = X % 10;
            Console.WriteLine(B);
        }
        static void Integer19()
        {
            int N = 1250;
            int M = N / 60;
            Console.WriteLine(M);
        }
        static void Integer20()
        {
            int N = 1250;
            int H = N / 3600;
            Console.WriteLine(H);
        }
        static void Integer21()
        {
            int N = 1250;
            int S = N % 60;
            Console.WriteLine(S);
        }
        static void Integer22()
        {
            int N = 1250;
            int S1 = N % 3600;
            Console.WriteLine(S1);
        }
        static void Integer23()
        {
            int N = 1250;
            int H = N / 3600;
            int M2 = H % 60;
            Console.WriteLine(M2);
        }
        static void Integer24()
        {
            int K = 125;
            int K1 = K + 1;
            int day = K1 % 7;
            Console.WriteLine(day);
        }
        static void Integer25()
        {
            int K = 12;
            int K1 = K + 4;
            int day = K1 % 7;
            Console.WriteLine(day);
        }
        static void Integer26()
        {
            int K = 12;
            int K1 = K + 1;
            int day = K1 % 7;
            Console.WriteLine(day + 1);
        }
        static void Integer27()
        {
            int K = 12;
            int K1 = K + 5;
            int day = K1 % 7;
            Console.WriteLine(day + 1);
        }
        static void Integer28()
        {
            int K = 12;
            int N = 3;
            int K1 = K + N - 1;
            int day = K1 % 7;
            Console.WriteLine(day + 1);
        }
        static void Integer29()
        {
            int A = 2;
            int B = 4;
            int C = 7;
            int X = (A / C) * (B / C);
            int S = X * C * C;
            int S1 = A * B - S;
            Console.WriteLine(X + " " + S1);
        }
        static void Integer30()
        {
            int A = 666;
            int Century = A / 100 + 1;
            Console.WriteLine(Century);
        }
    }
}
