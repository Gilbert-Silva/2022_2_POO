using System;
using System.Collections.Generic;

class Program {
  public static void Main() {
    Console.WriteLine("Opções: 1 - Inserir, 2 - Listar, 0 - Fim");
    int op = int.Parse(Console.ReadLine());
    while (op != 0) {
      switch(op) {
        case 1: 
          Console.Write("Informe o nome: ");
          string nome = Console.ReadLine();
          Console.Write("Informe a matrícula: ");
          string mat = Console.ReadLine();
          Console.Write("Informe a data de nascimento - yyyy-mm-dd: ");
          DateTime dt = DateTime.Parse(Console.ReadLine());
          Aluno aluno = new Aluno(nome, mat, dt); 
          NAluno.Inserir(aluno);
          break;
        case 2:
          foreach (Aluno a in NAluno.Listar()) 
            Console.WriteLine(a);  
          break;          
      }
      Console.WriteLine("Opções: 1 - Inserir, 2 - Listar, 0 - Fim");
      op = int.Parse(Console.ReadLine());
    }
  }
}

class NAluno { // negócio - operações
  private static List<Aluno> alunos = new List<Aluno>();
  public static void Inserir(Aluno a) {
    alunos.Add(a);
  }
  public static List<Aluno> Listar() {
    return alunos;
  }
}

class Aluno { // modelo - dados
  public string Nome { get; set; }
  public string Matricula { get; set; }
  public DateTime Nascimento { get; set; }
  public Aluno(string n, string m, DateTime dt) {
    Nome = n;
    Matricula = m;
    Nascimento = dt;
  }
  public override string ToString() {
    return $"{Nome} {Matricula} {Nascimento:dd/MM/yyyy}";
  }
}