using System;

class Program {
  public static void Main() {
    int[] v = { 5, 2, 1, 10, 6, 3, 8 };
    foreach(int i in v) Console.Write(i + " ");
    Console.WriteLine();
    Array.Sort(v);
    foreach(int i in v) Console.Write(i + " ");
  }  
}
