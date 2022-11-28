using System;

class Program {
  public static void Main() {
    int[] v = { 1, 2, 3, 4 };
    int[] x = v;
    int[] c = new int[4];
    Array.Copy(v, c, 4);
    x[0] = 10;
    foreach(int i in v)
      Console.WriteLine(i);
    foreach(int i in c)
      Console.WriteLine(i);
  }
}