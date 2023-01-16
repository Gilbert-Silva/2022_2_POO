using System; 
using Modelo;
using Negocio;

namespace Visao {

  class Program {
    public static int Menu() {
      Console.WriteLine("Opções: 1 - Inserir, 2 - Listar, 3 - Atualizar, 4 - Excluir, 0 - Fim");
      int op = int.Parse(Console.ReadLine());
      return op;      
    }
    public static void AlunoInserir() {
      //Console.Write("Informe o id do aluno: ");
      //int id = int.Parse(Console.ReadLine());
      Console.Write("Informe o nome: ");
      string nome = Console.ReadLine();
      Console.Write("Informe a matrícula: ");
      string mat = Console.ReadLine();
      Console.Write("Informe a data de nascimento - yyyy-mm-dd: ");
      DateTime dt = DateTime.Parse(Console.ReadLine());
      //Aluno aluno = new Aluno(id, nome, mat, dt); 
      Aluno aluno = new Aluno(nome, mat, dt); 
      NAluno.Inserir(aluno);
    }
    public static void AlunoListar() {
      foreach (Aluno a in NAluno.Listar()) 
        Console.WriteLine(a);  
    }
    public static void AlunoAtualizar() {
      Console.Write("Informe o id do aluno a ser atualizado: ");
      int id = int.Parse(Console.ReadLine());
      Console.Write("Informe o nome: ");
      string nome = Console.ReadLine();
      Console.Write("Informe a matrícula: ");
      string mat = Console.ReadLine();
      Console.Write("Informe a data de nascimento - yyyy-mm-dd: ");
      DateTime dt = DateTime.Parse(Console.ReadLine());
      //Aluno aluno = new Aluno(id, nome, mat, dt); 
      Aluno aluno = new Aluno(id, nome, mat, dt); 
      NAluno.Atualizar(aluno);
    }
    public static void AlunoExcluir() {
      Console.Write("Informe o id do aluno a ser atualizado: ");
      int id = int.Parse(Console.ReadLine());
      Aluno aluno = new Aluno {Id = id}; 
      NAluno.Excluir(aluno);
    }
    public static void Main() {
      int op = Menu();
      while (op != 0) {
        try {
          switch(op) {
            case 1: AlunoInserir(); break;
            case 2: AlunoListar(); break;         
            case 3: AlunoAtualizar(); break;         
            case 4: AlunoExcluir(); break;         
          }
        }
        catch (Exception erro) {
          Console.WriteLine(erro.Message + "\n");
        }
        op = Menu();
      }
    }
  }

}