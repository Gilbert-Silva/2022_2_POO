using System;
using System.Collections;

class Program {
  public static void Main() {
    Aluno a1 = new Aluno();
    a1.Nome = "Felipe";
    a1.Nascimento = DateTime.Parse("2000-01-01");
    Aluno a2 = new Aluno {
      Nome = "Radmila",
      Nascimento = DateTime.Parse("2001-10-10")
    };
    Aluno a3 = new Aluno {
      Nome = "Gilbert",
      Nascimento = DateTime.Parse("1990-10-10")
    };
    Aluno[] v = { a1, a2, a3 };
    Array.Sort(v);
    //a1.CompareTo(a2)
    //a1.CompareTo(a3)
    //a2.CompareTo(a3)
    foreach (Aluno elem in v) 
      Console.WriteLine(elem);

    ComparadorData objeto = new ComparadorData();
    Array.Sort(v, objeto);
    foreach (Aluno elem in v) 
      Console.WriteLine(elem);
    
  }
}

class ComparadorData : IComparer {
  public int Compare(object obj1, object obj2) {
    Aluno x1 = (Aluno) obj1;
    Aluno x2 = (Aluno) obj2;
    return x1.Nascimento.CompareTo(x2.Nascimento);
  }
}

class ComparadorNome : IComparer {
  public int Compare(object obj1, object obj2) {
    Aluno x1 = (Aluno) obj1;
    Aluno x2 = (Aluno) obj2;
    return x1.Nome.CompareTo(x2.Nome);
  }
}

class Aluno : IComparable {
  public string Nome { get; set; }
  public DateTime Nascimento { get; set; } 
  public override string ToString() {
    return $"{Nome} {Nascimento:dd/MM/yyyy}";
  }
  public int CompareTo(object obj) {
    Aluno x1 = this;
    Aluno x2 = (Aluno) obj;
    return x1.Nome.CompareTo(x2.Nome);
  }
}