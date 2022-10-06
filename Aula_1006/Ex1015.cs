using System;

class Program {
  public static void Main() {
    string l1 = Console.ReadLine();
    string l2 = Console.ReadLine();
    string[] p1 = l1.Split();
    string[] p2 = l2.Split();
    double x1 = double.Parse(p1[0]);
    double y1 = double.Parse(p1[1]);
    double x2 = double.Parse(p2[0]);
    double y2 = double.Parse(p2[1]);
    double d = Math.Sqrt (
      (x2-x1) * (x2-x1) + 
      Math.Pow(y2-y1, 2) );
    Console.WriteLine($"{d:0.0000}");
  }
}
