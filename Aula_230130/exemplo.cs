using System;
using System.Collections.Generic;

class Program {
  public static void Main() {
    Compromisso c1 = new Compromisso();    
    c1.Assunto = "Teste";
    Compromisso c2 = new Compromisso();    
    c2.Assunto = "Teste";
    Agenda agenda = new Agenda();
    //agenda.Inserir(c1);
    //agenda.Inserir(c2);
    //agenda.Inserir(c1);
    agenda.Inserir2(c1);
    agenda.Inserir2(c2);
  }
}
class Agenda {
  private List<Compromisso> comps = new List<Compromisso>();
  public void Inserir(Compromisso c) {
    if (comps.IndexOf(c) != -1)
      throw new InvalidOperationException("Compromisso já inserido");
    comps.Add(c);
  }
  public void Inserir2(Compromisso c) {
    foreach(Compromisso obj in comps)
    if (obj.Assunto == c.Assunto)
      throw new InvalidOperationException("Compromisso já inserido");
    comps.Add(c);
  }
}
class Compromisso {
  public string Assunto {get; set;}
}