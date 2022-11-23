using System;

class Program {
  public static void Main() {
    // Tipos por valor - ValueTypes
        // struct - int, double, bool, char, DateTime, TimeSpan
        // enum
        // A variável é a instância
    // Tipos por referência - ReferenceTypes
      // class - string
      // interface
      // delegate
      // object
      // dynamic
      // string
      // A variável é uma referência para a instância

    int x = 5;
    string s = new string("POO");
    Console.WriteLine(x);
    Console.WriteLine(s);
    x = 10;
    s = "Algoritmos"; // new string está implícito
    Console.WriteLine(x);
    Console.WriteLine(s);

    //int w;
    //Console.WriteLine(w);    
    Inteiro i = new Inteiro();
    i.valor = 10;
    Console.WriteLine(i.valor);
    Inteiro j = i;
    i.valor = 20;
    Console.WriteLine(j.valor);

    IComparable k = "POO";  // Interface
    Console.WriteLine(k);
    IComparable l = "C#";    
    Console.WriteLine(l);
    Console.WriteLine(k.CompareTo(l));
    Console.WriteLine(k.CompareTo(k));
    Console.WriteLine(l.CompareTo(k));
    object obj = "POO";
    string r = "POO";
    //Console.WriteLine(obj[0]);
    int[] v = {5, 4, 10, 3, 8};
    Array.Sort(v);
    foreach(int vi in v)
      Console.WriteLine(vi);
  }
}

class Inteiro {
  public int valor;
}

class Aluno {
  public string nome, matricula;
}