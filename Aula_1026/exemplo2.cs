using System;

class Program {  // UI
  public static void Main() {
    Disciplina poo = new Disciplina();
    try {
      Console.WriteLine("Informe a nota do 1º bimestre");
      poo.SetNota1(int.Parse(Console.ReadLine()));
      Console.WriteLine("Informe a nota do 2º bimestre");
      poo.SetNota2(int.Parse(Console.ReadLine()));
      if (poo.CalcMedia() < 60) {
        Console.WriteLine("Informe a nota final");
        poo.SetNotaFinal(int.Parse(Console.ReadLine()));
      }
      Console.WriteLine($"A média foi {poo.CalcMedia()}");  
    }
    catch {
      Console.WriteLine("A nota informada é inválida!");
    }
  }
}

class Disciplina { // Entity - Não usar Console
  private int nota1, nota2, notaFinal;
  public void SetNota1(int nota) { 
    if (nota >= 0 && nota <= 100) nota1 = nota;
    else throw new ArgumentOutOfRangeException();
  }
  public void SetNota2(int nota) {
    if (nota >= 0 && nota <= 100) nota2 = nota; // validação
    else throw new ArgumentOutOfRangeException();
  }
  public void SetNotaFinal(int nota) {
    if (nota >= 0 && nota <= 100) notaFinal = nota; // validação
    else throw new ArgumentOutOfRangeException();
  }
  public int CalcMedia() {
    int media = (2 * nota1 + 3 * nota2) / 5;
    if (media < 60) media = (media + notaFinal) / 2;
    return media;
  }
}