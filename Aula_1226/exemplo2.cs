using System;  
using System.Linq;  

delegate double Calculo (double d);
delegate double CalculoInt (int d);

class Program {
  public static void Main() {
    Calculo m1 = x => x * x * x;
    Calculo m2 = Cubo;
    Func<int, double> m3 = x => 2.5 * x;
    Console.WriteLine(m1(6));
    Console.WriteLine(m2(6));
    Console.WriteLine(m3(5));
    int[] w = { 1, 2, 3 };
    Array.ForEach<int>(w, Console.WriteLine);
    string s = "1 2 3";
    string[] vs = s.Split();
    foreach(int i in vs.Select(int.Parse))
      Console.WriteLine(i);
  }
  public static double Cubo (double x) {
    return x * x * x;
  }
}