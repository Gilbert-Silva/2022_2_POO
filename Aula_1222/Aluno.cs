using System;

namespace Modelo {

  public class Aluno { // modelo - dados
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Matricula { get; set; }
    public DateTime Nascimento { get; set; }
    // public Turma turma;
    public int IdTurma { get; set; }
    public Aluno() {}
    public Aluno(int id, string n, string m, DateTime dt) {
      Id = id;
      Nome = n;
      Matricula = m;
      Nascimento = dt;
    }
    public override string ToString() {
      return $"{Id}: {Nome} {Matricula} {Nascimento:dd/MM/yyyy}";
    }
  }

}