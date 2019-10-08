using System;

namespace Series
{
    class Program
    {
        static void Main(string[] args)
        {
            Series1();
            Series2();
            Series3();
            Series4();
            Series5();
            Series6();
            Series7();
            Series8();
            Series9();
            Series10();
            Series11();
            Series12();
            Series13();
            Series14();
            Series15();
        }

        static void Series1()
        {
            int [] nums = new int[10] { 1, 2, 3, 5, 6, 7, 8, 9, 10, 11 };
            int res = 0;

            for (int i = 0; i < nums.Length; i++)
            res += nums [i];
            Console.WriteLine(res);
        }

        static void Series2()
        {
            int[] nums = new int[10] { 1, 2, 3, 5, 6, 7, 8, 9, 10, 11 };
            int res = 1;

            for (int i = 0; i < nums.Length; i++)
                res *= nums[i];
            Console.WriteLine(res);
        }

        static void Series3()
        {
            int[] nums = new int[10] { 1, 2, 3, 5, 6, 7, 8, 9, 10, 11 };
            int res = 1;

            for (int i = 0; i < nums.Length; i++)
                res += nums[i];
            Console.WriteLine(res/10);
        }

        static void Series4()
        {
            int[] nums = new int[10] { 1, 2, 3, 5, 6, 7, 8, 9, 10, 11 };
            int result1 = 0;
            int result2 = 1;

            for (int i = 0; i < nums.Length; i++)
                result1 += nums[i];
            for (int i = 0; i < nums.Length; i++)
                result2 *= nums[i];
            Console.WriteLine(result1 + " " + result2);
        }

        static void Series5()
        {
            double sum = 0;
            double res;


            double[] nums = new double[10] { 1, 2.2, 3, 4.4 , 5, 6.6 , 7, 8.8 , 9, 10.10 };
            for (int i = 0; i < nums.Length; i++)
            {
                res = Math.Floor(nums[i]);
                sum += res;
                Console.Write(res + " ");
            }
            Console.Write("     " + sum);
            Console.WriteLine();
        }

        static void Series6()
        {
            double sum = 0;
            double res;

            double[] nums = new double[10] { 1, 2.2, 3, 4.4, 5, 6.6, 7, 8.8, 9, 10.10 };
            for (int i = 0; i < nums.Length; i++)
            {
                res = nums[i] % 1;
                sum += res;
                Console.Write(res + " ");
            }
            Console.Write("      " + sum);
            Console.WriteLine();
        }

        static void Series7()
        {
            double sum = 0;
            double res;

            double[] nums = new double[10] { 1, 2.2, 3, 4.4, 5, 6.6, 7, 8.8, 9, 10.10 };
            for (int i = 0; i < nums.Length; i++)
            {
                res = Math.Round(nums[i]);
                sum += res;
                Console.Write(res + " ");
            }
            Console.Write("      " + sum);
            Console.WriteLine();
        }

        static void Series8()
        {
            int[] nums = new int[10] { 1, 2, 3, 5, 6, 7, 8, 9, 10, 11 };
            int count = 0;

            for (int i = 0; i < nums.Length; i++)
                if (nums[i]%2==0)
                {
                    count += 1;
                    Console.Write(nums[i] + " ");
                }

            Console.Write("      " + count);
            Console.WriteLine();
        }

        static void Series9()
        {
            int[] nums = new int[10] { 1, 2, 3, 5, 6, 7, 8, 9, 10, 11 };
            int count = 0;

            for (int i = 0; i < nums.Length; i++)
                if (nums[i] % 2 != 0)
                {
                    count += 1;
                    Console.Write(nums[i] + " ");
                }

            Console.Write("      " + count);
            Console.WriteLine();
        }

        static void Series10()
        {
            int[] nums = new int[10] { 1, 2, 3, 5, 6, 7, 8, 9, 10, 11 };
            int count = 0;
            string res;

            for (int i = 0; i < nums.Length; i++)
                if (nums[i] > 0)
                {
                    count += 1;
                }
            if (count > 0)
            {
               res = "True";
            }
            else
            {
               res = "False";
            }
            Console.Write(res);
            Console.WriteLine();
        }

        static void Series11()
        {
            int[] nums = new int[10] { 1, 2, 3, 5, 6, 7, 8, 9, 10, 11 };
            int count = 0;
            int k = 5;

            for (int i = 0; i < nums.Length; i++)
                if (nums[i] < k)
                {
                    count += 1;
                }
                if(count>0)
                {
                Console.Write("True");
                }
                else
                {
                Console.Write("False");
                }

            Console.WriteLine();
        }

        static void Series12()
        {
            int[] nums = new int[10] { 1, 2, 3, 5, 6, 0, 8, 9, 10, 11 };
            var index = Array.IndexOf(nums, 0);
            int res = index + 1;
            Console.WriteLine(res);
            
        }

        static void Series13()
        {
            int[] nums = new int[10] { 1, 2, 3, 5, 6, 0, 8, 9, 10, 11 };
            int summer = 0, res;
            var index = Array.IndexOf(nums, 0);

            for (int i = 0; i < index ; i++)
                res =(nums[i] > 0 && nums[i] % 2 == 0 ? summer += nums[i] : summer += 0);
            Console.WriteLine(summer);
        }

        static void Series14()
        {
            int[] nums = new int[10] { 1, 2, 3, 5, 6, 0, 8, 9, 10, 11 };
            int res, count = 0, k = 3; 
            var index = Array.IndexOf(nums, 0);
            for (int i = 0; i < index; i++)
                res = (nums[i] < k? count += 1 : count += 0);
            Console.WriteLine(count);
        }

        static void Series15()
        {
            int[] nums = new int[10] { 1, 2, 3, 5, 6, 0, 8, 9, 10, 11 };
            int k = 3;
            var index = Array.IndexOf(nums, 0);
            for (int i = 0; i < index; i++)
                if(nums[i]>k)
                {
                    Console.WriteLine(nums[i]);
                    break;
                }
        }

    }
}
