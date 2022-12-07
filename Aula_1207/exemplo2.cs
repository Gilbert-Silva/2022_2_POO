using System;

class Program {
  public static void Main() {
    Aluno a1 = new Aluno();
    Console.WriteLine(a1.Nome);  // get
    a1.Nome = "Gilbert";
    Console.WriteLine(a1.Nome);  // get
    Console.WriteLine(a1.Nascimento);  
    Console.WriteLine(a1.Idade);
    a1.Nascimento = DateTime.Parse("2030-01-01");
    Console.WriteLine(a1.Nascimento);  
    Console.WriteLine(a1.Idade);
    //a1.Idade = 50;
    DateTime data = new DateTime (1582, 10, 15);
    Console.WriteLine(data);
    data = data.AddDays(-1);
    Console.WriteLine(data);
  }
}

class Aluno {
  private string nome = "Sem nome";
  public string Nome {
    get { return nome; }
    set { if (value != "") nome = value; }
  }
  public int Idade { // No último dia do ano
    get {
      DateTime hoje = DateTime.Now;
      int ano = hoje.Year;
      return ano - Nascimento.Year;
      // return DateTime.Now.Year - Nascimento.Year;
    }
  }
  /*  private DateTime nasc;
  public DateTime Nascimento {
    get { return nasc; }
    set { nasc = value; }
  }  */
  // Propriedade auto-implementada
  public DateTime Nascimento { get; set; } 
}