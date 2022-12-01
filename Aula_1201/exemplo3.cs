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
    Compromisso[] cs = new Compromisso[2];
    foreach(Compromisso c in x.Listar()) Console.WriteLine(c);
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