using System;

public interface IPessoa
{
  string GetNome();
  DateTime GetNascimento();
}

public class Relatorio
{
  public static void Aniversariantes(IPessoa[] v, int mes)
  {
    foreach (IPessoa p in v)
      if (p.GetNascimento().Month == mes)
          Console.WriteLine($"{p.GetNome()} {p.GetNascimento():dd/MM}");
  }
}

class Program
{
  static void Main(string[] args)
  {
      // IPessoa x =
  }
}
class Aluno : IPessoa
{
  public DateTime GetNascimento()
  {
    throw new NotImplementedException();
  }
  public string GetNome()
  {
    throw new NotImplementedException();
  }
}


