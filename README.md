Olimp



using System;

class MainClass {
  public static void Main (string[] args) {
    Program1();
    Program2();
  }

  static void Program1()
  {
    int n;   
    n = int.Parse(Console.ReadLine());
    int res = n*n;
    Console.WriteLine(res);
  }

  static void Program2()
  {
    int d1,d2,d3;   
    d1 = int.Parse(Console.ReadLine());
    d2 = int.Parse(Console.ReadLine());
    d3 = int.Parse(Console.ReadLine());
    int min1 = d1+2*d3+d2;
    int min2 = 2*d1+4*d3;
    int min3 = 2*d2+4*d3;
    int min4 = 2*d1+2*d2;
    if (min1 < min2 && min1 < min3 && min1 < min4)
    {
      Console.WriteLine(min1);
    }
    if (min2 < min1 && min2 < min3 && min2 < min4)
    {
      Console.WriteLine(min2);
    }
    if (min3 < min2 && min3 < min1 && min3 < min4)
    {
      Console.WriteLine(min3);
    }
    if (min4 < min2 && min4 < min3 && min4 < min1)
    {
      Console.WriteLine(min4);
    }

  }
}
