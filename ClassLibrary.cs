using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public static class Library
    {

    }
    public static class Rnd
    {


        private static Random R;

        public static int RandAtoB(int a, int b)
        {
            if (R == null) R = new Random();
            return R.Next(a, b);
        }

        public static int FastRand(int a, int b)
        {
            if (R == null) R = new Random();
            return R.Next(1, 100);
        }
    }

    public static class Gen
    {
        public static int[] ArrayIntAB(int a, int b, int Lenght)
        {
            int[] A = new int[Lenght];
            for (int i = 0; i < A.Length; i++)
            {
                A[i] = Rnd.RandAtoB(a, b);
            }
            return A;
        }

        public static int[] FastGen ()
        {
            int[] A = new int[10];
            for (int i = 0; i < A.Length; i++)
            {
                A[i] = Rnd.RandAtoB(1, 10);
            }
            return A;
        }
    }

    public static class Bool
    {
        public static bool IsPairing(int a)
        {
            return a % 2 == 0;
        }

        public static bool IsNotPairing(int a)
        {
            return a % 2 != 0;
        }
    }


    public static class Output
    {
        public static void WriteLine<T>(this T[] A)
        {
            foreach (var x in A) Console.Write(x + " ");
        }

    }
}

