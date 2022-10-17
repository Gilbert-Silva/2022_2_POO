using System;

class Program {
  public static void Main() {
    int n = int.Parse(Console.ReadLine());
    while (n != 0) {
      bool nenhum = false;
      string[] s = Console.ReadLine().Split();
      int x1 = int.Parse(s[0]);
      int y1 = int.Parse(s[1]);
      int u1 = int.Parse(s[2]);
      int v1 = int.Parse(s[3]);
      for (int i = 1; i < n; i++) {
        s = Console.ReadLine().Split();
        int x2 = int.Parse(s[0]);
        int y2 = int.Parse(s[1]);
        int u2 = int.Parse(s[2]);
        int v2 = int.Parse(s[3]);
        if (u2 >= x1 && u1 >= x2 && y2 >= v1 && y1 >= v2) {
          x1 = Math.Max(x1, x2);
          u1 = Math.Min(u1, u2);
          y1 = Math.Min(y1, y2);
          v1 = Math.Max(v1, v2);
        }
        else {
          nenhum = true;          
        }
      }
      if (nenhum) Console.WriteLine("nenhum");
      else Console.WriteLine($"{x1} {y1} {u1} {v1}");
      n = int.Parse(Console.ReadLine());
    }
  }
}