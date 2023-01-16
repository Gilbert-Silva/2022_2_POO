using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.IO;

class Program {
  public static void Main() {
    Console.WriteLine("Opções: 1 - Inserir, 2 - Listar, 3 - Salvar, 0 - Fim");
    int op = int.Parse(Console.ReadLine());
    while (op != 0) {
      switch(op) {
        case 1: 
          Console.Write("Informe o id do aluno: ");
          int id = int.Parse(Console.ReadLine());
          Console.Write("Informe o nome: ");
          string nome = Console.ReadLine();
          Console.Write("Informe a matrícula: ");
          string mat = Console.ReadLine();
          Console.Write("Informe a data de nascimento - yyyy-mm-dd: ");
          DateTime dt = DateTime.Parse(Console.ReadLine());
          Aluno aluno = new Aluno(id, nome, mat, dt); 
          NAluno.Inserir(aluno);
          break;
        case 2:
          foreach (Aluno a in NAluno.Listar()) 
            Console.WriteLine(a);  
          break;          
        case 3:
          NAluno.SalvarArquivo();
          break;          
      }
      Console.WriteLine("Opções: 1 - Inserir, 2 - Listar, 3 - Salvar, 0 - Fim");
      op = int.Parse(Console.ReadLine());
    }
  }
}

class NAluno { // negócio - operações
  private static List<Aluno> alunos = new List<Aluno>();
  public static void Inserir(Aluno a) {  // Create
    alunos.Add(a);
  }
  public static List<Aluno> Listar() {   // Read
    return alunos;
  }
  public static void SalvarArquivo() {
    // Classe que transforma (serialização) um objeto em xml
    // https://learn.microsoft.com/pt-br/dotnet/api/system.xml.serialization.xmlserializer?view=net-7.0
    XmlSerializer xml = new XmlSerializer(typeof(List<Aluno>));
    // Classe que manipula um arquivo - para gravar
    // https://learn.microsoft.com/en-us/dotnet/api/system.io.streamwriter?view=net-7.0
    StreamWriter stream = new StreamWriter("./alunos.xml", false);
    // https://learn.microsoft.com/pt-br/dotnet/api/system.xml.serialization.xmlserializer.serialize?view=net-7.0#system-xml-serialization-xmlserializer-serialize(system-io-stream-system-object)
    xml.Serialize(stream, alunos);
    stream.Close();
  }
  public static void AbrirArquivo() {
    
  }
}

public class Aluno { // modelo - dados
  public int Id { get; set; }
  public string Nome { get; set; }
  public string Matricula { get; set; }
  public DateTime Nascimento { get; set; }
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