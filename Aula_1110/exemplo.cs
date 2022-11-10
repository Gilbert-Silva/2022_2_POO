using System;

class Program {
  public static void Main() {
    int x = 5;
    string y = "TADS";
    Produto z = new Produto();
    object obj = y;
    object obj2 = z;
    object obj3 = x;
    x = 10;
    Console.WriteLine(obj3);
    int i = (int) obj3;
    Console.WriteLine(i);
  }
}

class Produto {
}
