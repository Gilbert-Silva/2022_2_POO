using System;

class Program {
  public static void Main() {
    string s = new string("Teste");
    Console.WriteLine(s);
    object obj = 10;
    Console.WriteLine(obj);
    obj = "Teste";
    Console.WriteLine(obj);
    dynamic x = 10;
    Console.WriteLine(x);
    //Console.WriteLine(x.Substring(0, 4));
    Console.WriteLine(x + 10);
    x = "10";
    Console.WriteLine(x + 10);
    x = "Informática";
    Console.WriteLine(x.Substring(0, 4));
    Aluno a1 = new Aluno();
    a1.nome = "Felipe";
    Aluno a2 = a1;
    a2.nome = "Gilbert";
    Console.WriteLine(a1.nome);
    Console.WriteLine(a2.nome);
    obj = a1;
  }
}

class Aluno {
  public string nome;
}
