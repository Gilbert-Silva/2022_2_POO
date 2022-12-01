// Lista 07 Exercício 04
using System;

class Program {
  public static void Main() {
    Compromisso c1 = new Compromisso {
      Assunto = "Aula de POO",
      Local = "Lab04",
      Data = DateTime.Parse("2022-11-30")
    };
    Compromisso c2 = new Compromisso {
      Assunto = "Avaliação de POO",
      Local = "Lab04",
      Data = DateTime.Parse("2022-12-07")
    };
    //Console.WriteLine(c1);
    //Console.WriteLine(c2);
    Agenda x = new Agenda();
    x.Inserir(c1);
    x.Inserir(c2);
    foreach(Compromisso c in x.Listar()) Console.WriteLine(c);
  }  
}

class Agenda {
  private Compromisso[] comps = new Compromisso[1];
  private int k = 0;
  public void Inserir(Compromisso c) {
    // https://learn.microsoft.com/pt-br/dotnet/api/system.array.resize?view=net-7.0
    if (k == comps.Length)
      Array.Resize(ref comps, 2 * comps.Length);
    comps[k++] = c;
  }
  public Compromisso[] Listar() {
    Compromisso[] vetor = new Compromisso[k];
    Array.Copy(comps, vetor, k);
    return vetor;
  }
}

class Compromisso {
  public string Assunto { get; set; }
  public string Local { get; set; }
  public DateTime Data { get; set; }
  public override string ToString() {
    return $"{Assunto} - {Local} - {Data:dd/MM/yyyy}";
  }
}