using System;
using System.Collections;

class Program {
  public static void Main() {
    Aluno[] vetor = {
        new Aluno("Felipe", DateTime.Parse("1999-10-10")),
        new Aluno("Yuri", DateTime.Parse("2000-1-10")),
        new Aluno("Cibele", DateTime.Parse("2001-10-30")),
    };
    Array.Sort(vetor);
    foreach(Aluno a in vetor)
      Console.WriteLine(a);
    Array.Sort(vetor, new AlunoNascComp());
    foreach(Aluno a in vetor)
      Console.WriteLine(a);
  }
}

class AlunoNascComp : IComparer {
  public int Compare(object x, object y) {
    // Comparação entre os objetos x e y
    return -((Aluno) x).Nasc.CompareTo(((Aluno)y).Nasc);
  }
}

class Aluno : IComparable {
  private string nome;
  private DateTime nasc;
  public DateTime Nasc { get { return nasc; }}
  public Aluno(string n, DateTime d) {
    this.nome = n;
    this.nasc = d;
  }
  public int CompareTo(object obj) {
    return nome.CompareTo(((Aluno)obj).nome);
  }
  public override string ToString() {
    return $"{nome} - {nasc:dd/MM/yyyy}";
  }
}