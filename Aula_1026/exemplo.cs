using System;
using System.Globalization;
using System.Threading;

class Program {
  public static void Main() {
    Thread.CurrentThread.CurrentCulture = new CultureInfo("pt-BR");
    Console.WriteLine("Digite um valor");
    double d = 1234.567;
    Console.WriteLine($"{d:f2}");
    Console.WriteLine($"{d:0.00}");
    Console.WriteLine($"{d:c2}"); // currency
  }
}