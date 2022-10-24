using System;
class Program {
  public static void Main() {
    Console.WriteLine("Digite seu nome");
    string s = Console.ReadLine();
    Console.WriteLine(FormatarTexto(s));
  }
  public static string FormatarTexto(string texto) {
    texto = texto.Trim();
    int p = texto.IndexOf("  ");
    while (p != -1) {
      texto = texto.Remove(p, 1);      
      p = texto.IndexOf("  ");
    }
    return texto;    
  }
}