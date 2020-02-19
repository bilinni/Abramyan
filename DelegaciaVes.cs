using System;

namespace ConsoleApp9
{
    class Program
    {
        delegate int OperationFir(int x);

        static void Main(string[] args)
        {
            int value = 4;
            
            OperationFir delFir = Sqr; 
            int result = delFir(value);
            Console.WriteLine(x2(result));
            

            Console.Read();
        }
        private static int Sqr(int x)
        {
            return x + x;
        }
        private static int x2(int delFir)
        {
            return (delFir * 2);
        }
    }
}
