using System; 
using Modelo;
using Negocio;

namespace Visao {

  class Program {
    public static int Menu() {
      Console.WriteLine("Opções: 1 - Inserir, 2 - Listar, 0 - Fim");
      int op = int.Parse(Console.ReadLine());
      return op;      
    }
    public static void AlunoInserir() {
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
      AlunoSalvar();
    }
    public static void AlunoListar() {
      foreach (Aluno a in NAluno.Listar()) 
        Console.WriteLine(a);  
    }
    public static void AlunoAbrir() {
      NAluno.AbrirArquivo();
    }
    public static void AlunoSalvar() {
      NAluno.SalvarArquivo();
    }
    public static void Main() {
      int op = Menu();
      AlunoAbrir();
      while (op != 0) {
        switch(op) {
          case 1: AlunoInserir(); break;
          case 2: AlunoListar(); break;         
        }
        op = Menu();
      }
    }
  }

}