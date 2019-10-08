using System;

namespace For
{
    class Program
    {
        static void Main(string[] args)
        {
            For1();
            For2();
            For3();
            For4();
            For5();
            For6();
            For7();
            For8();
            For9();
            For10();
            For11();
            For12();
            For13();
            For14();
            For15();
        }

        static void For1()
        {
            int k = 10;
            int n = 5;
            for (int i = 0; i < n; i++)
                Console.Write(k + " ");
            Console.WriteLine();
        }

        static void For2()
        {
            int A = 1;
            int B = 10;
            int N = 5;
            for (int i = 0; i < N; i++)
            {
                for (int j = A; j <= B; j++)
                    Console.Write(j + " ");
                Console.WriteLine();
            }
        }

        static void For3()
        {
            int A = 1;
            int B = 10;
            int N = 5;
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine();
                for (int j = B - 1; j > A; j--)
                    Console.Write(j + " ");
            }
            Console.WriteLine();
        }

        static void For4()
        {
            int kgprice = 12;
            int N = 10;
            for (int i = 1; i <= N; i++)
            {
                int kgcost = kgprice * i;
                Console.Write(kgcost + " ");
            }
            Console.WriteLine();
        }

        static void For5()
        {
            int kgprice = 12;
            int N = 10;
            for (int i = 1; i <= N; i++)
            {
                int kgcost = (kgprice * i) / 10;
                Console.Write(kgcost + " ");
            }
            Console.WriteLine();
        }

        static void For6()
        {
            int kgprice = 12;
            int N = 10;
            for (int i = 1; i <= N; i++)
            {
                int kgcostkg = (kgprice * i);
                int kgcostgr = (kgprice * i) / 5;
                int cost = (kgcostkg + kgcostgr);
                Console.Write(cost + " ");
            }
            Console.WriteLine();
        }

        static void For7()
        {
            int A = 1;
            int B = 5;
            int sum = 0;
            for (int i = A; i <= B; i++)
                sum += i;
            Console.Write(sum + " ");
            Console.WriteLine();
        }

        static void For8()
        {
            int A = 1;
            int B = 5;
            int dob = 1;
            for (int i = A; i <= B; i++)
                dob *= i;
            Console.Write(dob + " ");
            Console.WriteLine();
        }

        static void For9()
        {
            int A = 1;
            int B = 5;
            int sumkvad = 0;
            for (int i = A; i <= B; i++)
                sumkvad += i * i;
            Console.Write(sumkvad + " ");
            Console.WriteLine();
        }

        static void For10()
        {
            int n = 5;
            double res = 1;
            for (int i = 1; i >= n; i++)
                res += (res / i);
            Console.Write(res);
            Console.WriteLine();
        }

        static void For11()
        {
            int n = 5;
            int a = n;
            int res = 0;
            for (int i = 1; i <= n; i++)
                res += (a * a + 2 * a * i + i * i);


            Console.Write(res);
            Console.WriteLine();
        }

        static void For12()
        {
            int n = 20;
            double ten = 10;
            double res = 1;
            for (int i = 11; i < n; i++)
                res *= (i / ten);
            Console.Write(res);
            Console.WriteLine();
        }

        static void For13()
        {
            int N = 5;
            double res = 1.1;
            double ten = 10;
            for (int i = 12; i <= N; i++)
                res = res + ((i / ten) * (-1));
            Console.WriteLine(res);
        }

        static void For14()
        {
            int n = 5;
            int res = 0;
            for (int i = 1; i <= n; i++)
                res += 2 * i - 1;
            Console.WriteLine(res);
        }

        static void For15()
        {
            int n = 5;
            int a = 5;
            int res = 1;
            for (int i = 0; i < n; i++)
                res *= a;
            Console.WriteLine(res);
        }
    }
}
