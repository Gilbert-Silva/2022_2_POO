using System;

class Program {
  public static void Main() {
    int n = int.Parse(Console.ReadLine());
    for (int i = 1; i <= n; i++) {
      int x = int.Parse(Console.ReadLine());
      bool primo = true;
      for (int d = 2; d <= (int) Math.Sqrt(n); d++)
        if (x % d == 0) {
          primo = false;
          break;
        }

    }
  }
}