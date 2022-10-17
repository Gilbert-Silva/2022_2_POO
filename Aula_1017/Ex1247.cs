using System;

class Program {
  public static void Main() {
    string s = Console.ReadLine();
    while (string.IsNullOrEmpty(s) == false) {
      string[] v = s.Split();

      int d = int.Parse(v[0]);
      int vf = int.Parse(v[1]);
      int vg = int.Parse(v[2]);
      double tf = 12.0/vf;
      double tg = Math.Sqrt(12*12 + d*d)/vg;
      if (tg <= tf) Console.WriteLine("S");
      else Console.WriteLine("N");

      s = Console.ReadLine();
    }
  }
}