using System;

enum Estação {
  Primavera = 0, Verão = 1, Outono = 2, Inverno = 4
  }

class Program {
  public static void Main() {
    int x = 5;
    Estação y = Estação.Verão;
    y = (Estação) 3;
    Console.WriteLine(x);
    Console.WriteLine(y);
    
  }
}

