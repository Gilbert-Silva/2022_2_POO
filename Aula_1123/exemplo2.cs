using System;
using System.Globalization;
using System.Threading;

class Program {
  public static void Main() {
    Thread.CurrentThread.CurrentCulture = 
      new CultureInfo("pt-BR");
                             
    Console.WriteLine("Informe a data de nascimento");
    string s = Console.ReadLine();
    DateTime dt = DateTime.Parse(s);
    Console.WriteLine(dt);
    DateTime hoje = DateTime.Now; // Propriedade
    int anos = hoje.Year - dt.Year;
    int meses = hoje.Month - dt.Month;
    if (meses < 0) {
      meses += 12; anos--;
    }
    Console.WriteLine($"{anos} ano(s) e {meses} mes(es)");
  }
}