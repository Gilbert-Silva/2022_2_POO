using System;

class Program {
  public static void Main() {
    object x = 10;
    object y = "Python";
    object z = new Aluno("Gilbert", DateTime.Now);
    Console.WriteLine(x);
    Console.WriteLine(y);
    Console.WriteLine(z);
    Colecao c = new Colecao(10);
    c.Inserir(x);
    c.Inserir(y);
    c.Inserir(z);
    c.Inserir(c);
    //vetor[0] 
  }
}

class Colecao {
  private object[] itens;
  private int max;
  private int k;
  public Colecao(int max) {
    itens = new object[max];
    this.max = max; // max = itens.Length
  }
  public void Inserir(object item) {
    if (k < max) itens[k++] = item;
  }
}

class Aluno : IComparable {
  private string nome;
  private DateTime nasc;
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