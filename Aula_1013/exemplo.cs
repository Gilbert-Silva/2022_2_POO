using System;

class Program {
  public static void Main() {
    string s;
    do {
      Console.WriteLine("Faz alguma coisa");
      Console.WriteLine("Roda de novo sim/nao?");
      s = Console.ReadLine();
    } while (s == "sim");

    int n = int.Parse(Console.ReadLine());
    
    int i = 1;
    while (i <= n) {
      Console.WriteLine(i);
      i++;
    }
    Console.WriteLine();
    i = 1;
    do {
      Console.WriteLine(i);
      i++;
    } while (i <= n);
    Console.WriteLine();
    for(int k = 1; k <= n; k++) {
      Console.WriteLine(k);
    }
    
  }
}
/*
i = 1
while i <= n:
  print(i)
  i += 1
*/