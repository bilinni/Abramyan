using System;

namespace Case
{
    class Program
    {
        static void Main(string[] args)
        {
            Case1();
            Case2();
            Case3();
            Case4();
            Case5();
            Case6();
            Case7();
            Case8();
            Case9();
            Case10();
            Case11();
            Case12();

        }

        static void Case1()
        {
            int x = 3;
            string r = " ";
            switch (x)
            {
                case 1:
                    r = "Понедельник";
                    break;

                case 2:
                    r = "Вторник";
                    break;

                case 3:
                    r = "Среда";
                    break;

                case 4:
                    r = "Четверг";
                    break;

                case 5:
                    r = "Пятница";
                    break;

                case 6:
                    r = "Суббота";
                    break;

                case 7:
                    r = "Воскресенье";
                    break;

                default:
                    r = "ERR0R";
                    break;
            }
            Console.WriteLine(r);

        }

        static void Case2()
        {
            int x = 3;
            string r = " ";
            switch (x)
            {
                case 1:
                    r = "плохо";
                    break;

                case 2:
                    r = "«неудовлетворительно";
                    break;

                case 3:
                    r = "удовлетворительно";
                    break;

                case 4:
                    r = "хорошо";
                    break;

                case 5:
                    r = "«отлично";
                    break;

                default:
                    r = "ERR0R";
                    break;

            }
            Console.WriteLine(r);
        }

        static void Case3()
        {
            int x = 8;
            string r = " ";
            switch (x)
            {
                case 9:
                case 10:
                case 11:
                    r = "Осень";
                    break;

                case 12:
                case 1:
                case 2:
                    r = "Зима";
                    break;

                case 3:
                case 4:
                case 5:
                    r = "Весна";
                    break;

                case 6:
                case 7:
                case 8:
                    r = "Лето";
                    break;

                default:
                    r = "ERR0R";
                    break;

            }
            Console.WriteLine(r);
        }

        static void Case4()
        {
            int x = 8;
            int r = 0;
            switch (x)
            {

                case 4:
                case 6:
                case 9:
                case 11:
                    r = 30;
                    break;

                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    r = 31;
                    break;
                case 2:
                    r = 28;
                    break;

                default:
                    r = 0;
                    break;

            }
            Console.WriteLine(r);
        }

        static void Case5()
        {
            int x = 3;
            int a = 10;
            int b = 4;
            int r = 0;
            switch (x)
            {
                case 1:
                    r = a + b;
                    break;

                case 2:
                    r = a - b;
                    break;

                case 3:
                    r = a * b;
                    break;

                case 4:
                    r = a / b;
                    break;

                default:
                    r = 0;
                    break;

            }
            Console.WriteLine(r);
        }

        static void Case6()
        {
            int x = 3;
            int a = 10;
            int r = 0;
            switch (x)
            {
                case 1:
                    r = a / 10;
                    break;

                case 2:
                    r = a * 1000;
                    break;

                case 3:
                    r = a;
                    break;

                case 4:
                    r = a / 1000;
                    break;

                case 5:
                    r = a / 100;
                    break;

                default:
                    r = 0;
                    break;

            }
            Console.WriteLine(r);
        }

        static void Case7()
        {
            int x = 3;
            int a = 10;
            int r = 0;
            switch (x)
            {
                case 1:
                    r = a ;
                    break;

                case 2:
                    r = a / 10000;
                    break;

                case 3:
                    r = a / 1000;
                    break;

                case 4:
                    r = a * 1000;
                    break;

                case 5:
                    r = a / 10;
                    break;

                default:
                    r = 0;
                    break;

            }
            Console.WriteLine(r);
        }

        static void Case8()
        {
            
            int d = 3;
            int m = 10;
            
            switch (m)
            {
                case 5:
                case 7:
                case 10:
                case 12:
                    m -= 1;
                    if (d == 1)
                    {
                        d = 30;
                    }
                    else
                    {
                        d -= 1;
                    }
                    break;

                case 2:
                case 4:
                case 6:
                case 8:
                case 9:
                case 11:
                case 1:
                    m -= 1;
                    if (d == 1)
                    {
                        d = 31;
                    }
                    else
                    {
                        d -= 1;
                    }
                    break;
                    
                case 3:
                    m -= 1;
                    if (d == 1)
                    {
                        d = 28;
                    }
                    else
                    {
                        d -= 1;
                    }
                   
                    break;

                default:
                    d = 0;
                    break;


            }
            Console.WriteLine(d + " " + m);
        }

        static void Case9()
        {

            int d = 3;
            int m = 10;

            switch (m)
            {
                case 3:
                case 5:
                case 8:
                case 10:
                    m += 1;
                    if (d == 30)
                    {
                        d = 1;
                    }
                    else
                    {
                        d += 1;
                    }
                    break;

                case 12:
                case 2:
                case 4:
                case 6:
                case 7:
                case 9:
                case 11:
                    m += 1;
                    if (d == 31)
                    {
                        d = 1;
                    }
                    else
                    {
                        d += 1;
                    }
                    break;

                case 1:
                    m += 1;
                    if (d == 28)
                    {
                        d = 1;
                    }
                    else
                    {
                        d += 1;
                    }

                    break;

                default:
                    d = 0;
                    break;


            }
            Console.WriteLine(d + " " + m);
        }

        static void Case10()
        {

            string c ="C";
            int n = 0;

            switch (n)
            {
                
                case 1:

                    if (c == "C")
                    {
                        c = "Z";
                    }
                    else if (c == "Z")
                    {
                        c = "U";
                    }
                    else if (c == "U")
                    {
                        c = "V";
                    }
                    else
                        c = "C";
                    break;

               
                case -1:


                    if (c == "C")
                    {
                        c = "V";
                    }
                    else if (c == "Z")
                    {
                        c = "C";
                    }
                    else if (c == "U")
                    {
                        c = "Z";
                    }
                    else
                        c = "U";
                    break;

                case 0:

                    c = c;

                    break;

                default:
                    c = "Error";
                    break;


            }
            Console.WriteLine(c);
        }

        static void Case11()
        {

            string c = "C";
            int n = 0;

            switch (n)
            {

                case 1:

                    if (c == "C")
                    {
                        c = "Z";
                    }
                    else if (c == "Z")
                    {
                        c = "U";
                    }
                    else if (c == "U")
                    {
                        c = "V";
                    }
                    else
                        c = "C";
                    break;


                case -1:


                    if (c == "C")
                    {
                        c = "V";
                    }
                    else if (c == "Z")
                    {
                        c = "C";
                    }
                    else if (c == "U")
                    {
                        c = "Z";
                    }
                    else
                        c = "U";
                    break;

                case 0:

                    if (c == "C")
                    {
                        c = "U";
                    }
                    else if (c == "Z")
                    {
                        c = "V";
                    }
                    else if (c == "U")
                    {
                        c = "C";
                    }
                    else
                        c = "Z";
                    break;

                default:
                    c = "Error";
                    break;


            }
            Console.WriteLine(c);
        }

        static void Case12()
        {
            int x = 1;
            double r = 2;
            double d = 3;
            double l = 4;
            double s = 5;
            switch(x)
            {
                case 1:
                    d = (2 * r);
                    l = (2 * r * Math.PI);
                    s = (Math.PI * r * r);

                    break;

                case 2:
                    r = (d / 2);
                    l = (2 * Math.PI * d / 2);
                    s = (d / 2 * d / 2 * Math.PI);

                    break;

                case 3:
                    r = (l / 2 * Math.PI);
                    d = (l / 2 * Math.PI * 2);
                    s = (l / 2 * Math.PI * l / 2 * Math.PI * Math.PI);

                    break;

                case 4:
                    r = (Math.Sqrt(s / Math.PI));
                    l = (2 * Math.Sqrt(s / Math.PI));
                    d = (Math.PI * Math.Sqrt(s / Math.PI * 2));

                    break;
                
            }
                    Console.WriteLine(r + " " + d + " " + l + " " + s);
        }
    }
}
