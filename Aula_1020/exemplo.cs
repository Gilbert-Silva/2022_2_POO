using System;

class Program {
  public static void Main() {
    Aluno x;         // Referência
    x = new Aluno(); // Instância - new
    x.nome = "Radmila";
    x.matricula = "20221014041234";
    Aluno y = new Aluno();
    y.nome = "Felipe";
    y.matricula = "20201014044321";
    Aluno z = x;
    Console.WriteLine(x.nome + " " + x.matricula);    
    Console.WriteLine(y.nome + " " + y.matricula);    
    Console.WriteLine(z.nome + " " + z.matricula); 
    Console.WriteLine(x.AnoIngresso());
    Console.WriteLine(y.AnoIngresso());
    /*
    //int a = 5;
    //int b = a;
    Aluno[] lista = { x, y };
    foreach (Aluno aluno in lista)
      Console.WriteLine(aluno.nome);
    object o1 = 5;
    object o2 = "teste";
    object o3 = new Aluno();
    object[] o = {1, "teste", new Aluno()};
    */
    Diario d = new Diario();
    d.disciplina = "POO";
    d.lista[0] = x;
    d.lista[1] = y;
    foreach (Aluno aluno in d.lista)
      if (aluno != null)
        Console.WriteLine(aluno.nome);
  }
}

class Diario {
  public string disciplina;
  public Aluno[] lista = new Aluno[10];
}

class Aluno {
  // atributos
  public string nome;
  public string matricula;
  // métodos
  public int AnoIngresso() {
    string ano = matricula.Substring(0, 4);
    return int.Parse(ano);
  }
}