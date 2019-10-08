using System;

namespace While
{
    class Program
    {
        static void Main(string[] args)
        {
            While1();
            While2();
            While3();
            While4();
            While5();
            While6();
            While7();
            While8();
            While9();
            While10();
            While11();
            While12();
            While13();
            While14();
            While15();
        }

        static void While1()
        {
            int a = 10;
            int b = 3;
            int res = 0;
            while (a > b)
            {
                res += b;
                a -= res;
            }
            Console.WriteLine(a);
        }

        static void While2()
        {
            int a = 10;
            int b = 3;
            int count = 0;
            while (a > b)
            {
                count += 1;
                a -= b;
            }
            Console.WriteLine(count);
        }

        static void While3()
        {
            int n = 10;
            int nc = n;
            int k = 3;
            int res = 0;
            int count = 0;
            while (n > k)
            {
                res += k;
                count += 1;
                n -= k;
            }
            Console.WriteLine(count + " " + (nc - res));
        }

        static void While4()
        {
            int n = 27;
            int k = 1;

            while (n > k)
            {
                k *= 3;
            }
            if (n == k)
                Console.WriteLine("True");
            else          
                Console.WriteLine("False");         
        }

        static void While5()
        {
            int n = 1024;
            int k = 0;
            int res = 1;
            while (n > res)
            {
                res *= 2;
                k += 1;
            }
            if (res==n)
            {
                Console.WriteLine("True");
            }
            else
                Console.WriteLine("False");
        }

        static void While6()
        {
            int n = 5;
            int res = 1;
            int i = 0;
            int c = 0;

            while (n > c)
            {
                res*=(n - i);
                i += 2;
                c += 1;
            }
             res*= (n % 2 == 0 ? 2 : 1);
            Console.WriteLine(res);
        }

        static void While7()
        {
            int k = 0;
            int n = 9;
            while (n >= k * k)
            {
                k += 1;
            }
             Console.WriteLine(k);
        }

        static void While8()
        {
            int k = 0;
            int n = 9;
            while (n > k * k)
            {
                k += 1;
            }
            int test = (k > n ? k = k : k -= 1);
            Console.WriteLine(test);
        }

        static void While9()
        {
            int k = 0;
            int step = 1;
            int n = 9;
            while (n >= step)
            {
                step *= 3;
                k += 1;
            }
            Console.WriteLine(k);
        }

        static void While10()
        {
            int k = 0;
            int step = 1;
            int n = 9;
            while (n > step)
            {
                step *= 3;
                k += 1;
            }
            int test = (step > n ? k = k - 1 : k = k);
            Console.WriteLine(k);
        }

        static void While11()
        {
            int n = 9;
            int count = 0;
            int kef = 0;
            int k = 0;
            while(n>k)
            {
                kef += 1;
                k += kef;
                count+= 1;
                
            }
            
            Console.WriteLine(count);
        }

        static void While12()
        {
            int n = 9;
            int count = 0;
            int kef = 0;
            int k = 0;
            while (n > k)
            {
                kef += 1;
                k += kef;
                count += 1;

            }
            int res = (n < k ? res=count-1 : res=count);
            Console.WriteLine(res);
        }

        static void While13()
        {
             double A = 9, K = 0, S=0;

            while (S <= A)
            {
                K += 1;
                S += (1 / K);
            }
            Console.WriteLine(K + " " + S);

        }

        static void While14()
        {
            double A = 9, K = 0, S = 0;

            while (S > A)
            {
                K += 1;
                S += (1 / K);
            }

            Console.WriteLine(K + " " + S);

        }


        static void While15()
        {
            int vklad = 1000, proc = 15, res = 0;
            int ms = 0;
            while (res <= 1100)
            {
                res += vklad * proc / 100;
                ms += 1; 
            }
            Console.WriteLine(ms);
        }
    }
}
