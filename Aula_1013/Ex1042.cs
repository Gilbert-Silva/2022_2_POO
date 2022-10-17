using System;

class Program {
  public static void Main() {
    string[] s = Console.ReadLine().Split();
    int a = int.Parse(s[0]);
    int b = int.Parse(s[1]);
    int c = int.Parse(s[2]);
    //int[] v = { a, b, c }; Array.Sort(v);
    if (a > b) {
      int x = a;
      a = b;
      b = x;
    }
    if (a > c) {
      int x = a;
      a = c;
      c = x;
    }
    if (b > c) {
      int x = b;
      b = c;
      c = x;
    }
    Console.WriteLine($"{a}\n{b}\n{c}\n\n{s[0]}\n{s[1]}\n{s[2]}");
  }
}